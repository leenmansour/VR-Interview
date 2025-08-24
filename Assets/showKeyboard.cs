using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
using UnityEngine.SceneManagement;

public class showKeyboard : MonoBehaviour
{

    private TMP_InputField inputField;
    public TMP_Dropdown bootcampDropdown;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputField = GetComponent<TMP_InputField>();
        inputField.onSelect.AddListener( x => OpenKeyboard());
    }

    // Update is called once per frame
   public void OpenKeyboard(){
    NonNativeKeyboard.Instance.InputField= inputField;
    NonNativeKeyboard.Instance.PresentKeyboard(inputField.text);
   }

 public void OnSubmit()
{
    PlayerName.UserName = NonNativeKeyboard.Instance.InputField.text;
    Debug.Log("Submitted name: " + PlayerName.UserName);
    PlayerName.SelectedBootcamp = bootcampDropdown.value; 
    SceneManager.LoadScene("Interview");
}
}
