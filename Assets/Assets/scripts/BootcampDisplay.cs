using UnityEngine;
using UnityEngine.UI;

public class BootcampDisplay : MonoBehaviour
{
    [Header("UI Reference")]
    public Image displayImage; // Drag your Image component here in Inspector

    [Header("Bootcamp Sprites")]
    public Sprite cybersecuritySprite;
    public Sprite xrSprite;
    public Sprite UXUIsprite;

    void Start()
    {
        UpdateBootcampDisplay();
    }

    void UpdateBootcampDisplay()
    {
        switch (PlayerName.SelectedBootcamp)
        {
            case 0: // Cybersecurity
                displayImage.sprite = cybersecuritySprite;
                break;
            case 1: // XR
                displayImage.sprite = xrSprite;
                break;
            case 2: // UXUIsprite
                displayImage.sprite = UXUIsprite;
                break;
        }
    }
}
