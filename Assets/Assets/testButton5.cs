using UnityEngine;
using UnityEngine.InputSystem;

public class testButton5 : MonoBehaviour
{
    public InputActionProperty Action1;
    public GameObject a1;

    void Update()
    {
        if (Action1.action.WasPressedThisFrame())
        {
            Animator anim = a1.GetComponent<Animator>();
            if (anim != null)
            {
                anim.SetTrigger("PlayAnim"); // نشغل الأنيميشن
            }
        }
    }
}
