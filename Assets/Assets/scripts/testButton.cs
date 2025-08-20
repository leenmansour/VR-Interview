using UnityEngine;
using UnityEngine.InputSystem;

public class testButton : MonoBehaviour
{
    public InputActionProperty Action1;
    public InputActionProperty Action2;
    public InputActionProperty Action3;
    public InputActionProperty Action4;

    public GameObject a1;
    public GameObject text;
    public GameObject otherColors;
    public AudioSource audio;

    public Animator cylinderAnimator;
    //public Color newColor2; // اللون الجديد لـ Action2
    //public Color newColor3; // اللون الجديد لـ Action3

    void Update()
    {
        // Action1: إخفاء العنصر وتشغيل الصوت
        if (Action1.action.WasPressedThisFrame())
        {
            //a1.SetActive(false);
            audio.Play();
            cylinderAnimator.SetTrigger("PlayAnim");
        }

        // Action2: نص اسم المجسم
        if (Action2.action.WasPressedThisFrame())
        {
            text.SetActive(!text.activeSelf);
        }


        // Action3: عرض الالوان الأخرى
        if (Action3.action.WasPressedThisFrame())
        {
           
             bool isActive = otherColors.activeSelf; 
            otherColors.SetActive(!isActive);
        }

        // Action4: اخفاء 
        if (Action4.action.WasPressedThisFrame())
        {
                a1.SetActive(!a1.activeSelf);
    
        }
    }
}
