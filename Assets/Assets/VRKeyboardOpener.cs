using UnityEngine;
using TMPro;

public class VRKeyboardOpener : MonoBehaviour
{
    public TMP_InputField input;
    public void OpenKeyboard()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        TouchScreenKeyboard.Open(input.text, TouchScreenKeyboardType.Default, false, false, false, false);
#endif
        input.ActivateInputField();
    }
}
