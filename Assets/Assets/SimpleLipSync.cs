using UnityEngine;

public class SimpleLipSync : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource convaiAudio;

    [Header("Face")]
    public SkinnedMeshRenderer skinnedMesh;
    public string jawBlendShape = "jawOpen";

    private int jawIndex;

    void Start()
    {
        if (skinnedMesh != null && skinnedMesh.sharedMesh != null)
            jawIndex = skinnedMesh.sharedMesh.GetBlendShapeIndex(jawBlendShape);
    }

    void Update()
    {
        if (convaiAudio != null && convaiAudio.isPlaying && jawIndex >= 0)
        {
            float[] samples = new float[256];
            convaiAudio.GetOutputData(samples, 0);

            float sum = 0f;
            for (int i = 0; i < samples.Length; i++)
                sum += samples[i] * samples[i];

            float rms = Mathf.Sqrt(sum / samples.Length);

            // نحرك الفم حسب قوة الصوت
            float jawValue = Mathf.Clamp(rms * 1000f, 0f, 100f);
            skinnedMesh.SetBlendShapeWeight(jawIndex, jawValue);
        }
        else if (jawIndex >= 0)
        {
            // نخلي الفم مقفل إذا مافي صوت
            skinnedMesh.SetBlendShapeWeight(jawIndex, 0f);
        }
    }
}
