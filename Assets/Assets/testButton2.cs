using UnityEngine;
using UnityEngine.InputSystem;

public class testButton2 : MonoBehaviour
{
    public InputActionProperty Action1;
    public GameObject a1;
    public Color newColor ; // اللون الجديد

    void Update()
    {
        if (Action1.action.WasPressedThisFrame())
        {
            Renderer rend = a1.GetComponent<Renderer>();
            if (rend != null)
            {
                rend.material.color = newColor;
            }
        }
    }
}