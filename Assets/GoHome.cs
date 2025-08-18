using UnityEngine;
using UnityEngine.SceneManagement;

public class GoHome : MonoBehaviour
{
   
   
    // This function will be called when the icon is clicked
    public void OnClickHome()
    {
        SceneManager.LoadScene("homeScene");
    }
}
