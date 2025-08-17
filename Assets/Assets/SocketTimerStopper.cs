using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketTimerStopper : MonoBehaviour
{
    public CountdownTimer timerScript; // اسحبيه من TimerManager
    public string targetTag = "Ball";  // اسم التاغ حق الكرة

    private UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socket;

    void Awake()
    {
        socket = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>();
        socket.selectEntered.AddListener(OnSelectEntered);
    }

    void OnDestroy()
    {
        socket.selectEntered.RemoveListener(OnSelectEntered);
    }

    void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.CompareTag(targetTag))
        {
            timerScript.StopTimer();
            Debug.Log("✅ الكرة دخلت السلة (Socket)! أوقف التايمر.");
        }
    }
}
