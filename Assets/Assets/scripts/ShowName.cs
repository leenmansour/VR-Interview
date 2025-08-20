using UnityEngine;
using TMPro;

public class ShowName : MonoBehaviour
{
    public TextMeshProUGUI nameText;

    void Start()
    {
        nameText.text = PlayerData.UserName;
    }
}
