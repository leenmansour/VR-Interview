using UnityEngine;
using TMPro;

public class ShowName : MonoBehaviour
{
    public TextMeshProUGUI nameText;

    void Start()
    {
        if (nameText != null)   // ✅ prevents crash
        {
            nameText.text = PlayerName.UserName;
        }
        else
        {
            Debug.LogError("ShowName: nameText reference is missing!");
        }
    }
}
