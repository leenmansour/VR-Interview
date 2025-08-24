using UnityEngine;

public class SyncAnimationWithVoice : MonoBehaviour
{
    public AudioSource convaiAudio;       // حطي هنا الـ AudioSource حق Convai
    public Animator newCharacterAnimator; // الأنيميتر للشخصية الجديدة
    public string talkingAnimationTrigger = "Talk"; // اسم التريجر/الباراميتر في Animator

    private bool isTalking = false;

    void Update()
    {
        if (convaiAudio != null && newCharacterAnimator != null)
        {
            if (convaiAudio.isPlaying && !isTalking)
            {
                // إذا بدأ الصوت
                newCharacterAnimator.SetBool(talkingAnimationTrigger, true);
                isTalking = true;
            }
            else if (!convaiAudio.isPlaying && isTalking)
            {
                // إذا وقف الصوت
                newCharacterAnimator.SetBool(talkingAnimationTrigger, false);
                isTalking = false;
            }
        }
    }
}
