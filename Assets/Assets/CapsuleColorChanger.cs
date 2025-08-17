using UnityEngine;

public class CapsuleColorChanger : MonoBehaviour
{
    public Renderer capsuleRenderer;

    // قائمة ألوان تختارينها من Unity
    public Color[] availableColors;

    public void ChangeToRandomColor()
    {
        if (availableColors.Length == 0 || capsuleRenderer == null)
            return;

        int randomIndex = Random.Range(0, availableColors.Length);
        capsuleRenderer.material.color = availableColors[randomIndex];
    }
}
