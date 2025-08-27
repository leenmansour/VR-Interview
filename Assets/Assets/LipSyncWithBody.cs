using UnityEngine;
using System.Collections;

public class LipSyncWithBody : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource convaiAudio;

    [Header("Face")]
    public SkinnedMeshRenderer skinnedMesh;
    public string jawBlendShape = "jawOpen";      

    [Header("Body Animation")]
    public Animator characterAnimator;
    public string talkingBool = "Talk";

    private int jawIndex;
    private bool isTalking = false; 
    private Coroutine stopTalkingCoroutine;

    [Header("Voice Settings")]
    public float talkingThreshold = 5f;     // الحد الأدنى لاعتبار الصوت كلام
    public float stopDelay = 0.25f;         // وقت الانتظار قبل إيقاف الكلام

    void Start()
    {
        // نحصل على Index حق الفم
        jawIndex = skinnedMesh.sharedMesh.GetBlendShapeIndex(jawBlendShape);
    }

    void Update()
    {
        bool currentlyTalking = false;

        if (convaiAudio != null && convaiAudio.isPlaying && jawIndex >= 0)
        {
            float[] samples = new float[256];
            convaiAudio.GetOutputData(samples, 0);

            float sum = 0f;
            for (int i = 0; i < samples.Length; i++)
                sum += samples[i] * samples[i];

            float rms = Mathf.Sqrt(sum / samples.Length);
            float jawValue = Mathf.Clamp(rms * 1000f, 0f, 100f);

            // نحرك الفم حسب قوة الصوت
            skinnedMesh.SetBlendShapeWeight(jawIndex, jawValue);

            currentlyTalking = jawValue > talkingThreshold;

            if (currentlyTalking)
            {
                if (stopTalkingCoroutine != null)
                {
                    StopCoroutine(stopTalkingCoroutine);
                    stopTalkingCoroutine = null;
                }

                if (!isTalking && characterAnimator != null)
                {
                    characterAnimator.SetBool(talkingBool, true);
                    isTalking = true;
                }
            }
            else
            {
                if (stopTalkingCoroutine == null)
                    stopTalkingCoroutine = StartCoroutine(StopTalkingAfterDelay());
            }
        }
    }

    private IEnumerator StopTalkingAfterDelay()
    {
        yield return new WaitForSeconds(stopDelay);
        if (characterAnimator != null)
            characterAnimator.SetBool(talkingBool, false);
        isTalking = false;
        stopTalkingCoroutine = null;
    }
}
