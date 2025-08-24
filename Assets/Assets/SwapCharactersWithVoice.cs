using UnityEngine;

public class SwapCharactersWithVoice : MonoBehaviour
{
    public AudioSource convaiAudio;   // الصوت حق Convai
    public GameObject idleCharacter;  // الشخصية بوضع Idle
    public GameObject talkingCharacter; // الشخصية بوضع Talking

    void Update()
    {
        if (convaiAudio.isPlaying)
        {
            idleCharacter.SetActive(false);
            talkingCharacter.SetActive(true);
        }
        else
        {
            idleCharacter.SetActive(true);
            talkingCharacter.SetActive(false);
        }
    }
}
