using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StartInterviewUI : MonoBehaviour
{
    [Header("UI References")]
    public TMP_InputField nameInput;
    public Button submitButton;

    [Header("Scene")]
    public string interviewSceneName = "Interview"; // set to your exact scene name

    void Awake()
    {
        if (submitButton != null) submitButton.onClick.AddListener(OnSubmit);
        if (nameInput != null) nameInput.onValueChanged.AddListener(_ => UpdateInteractable());
        UpdateInteractable();
    }

    void OnDestroy()
    {
        if (submitButton != null) submitButton.onClick.RemoveListener(OnSubmit);
        if (nameInput != null) nameInput.onValueChanged.RemoveAllListeners();
    }

    void UpdateInteractable()
    {
        if (submitButton != null && nameInput != null)
            submitButton.interactable = !string.IsNullOrWhiteSpace(nameInput.text);
    }

   public void OnSubmit()
{
    Debug.Log("Submit clicked");
    
    SceneManager.LoadScene("Interview");
}

}
