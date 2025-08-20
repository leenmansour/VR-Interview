using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(Animator))]
public class HandAnimatorDriver : MonoBehaviour
{
    public ActionBasedController controller; // assign Left/Right Controller
    [Header("Animator parameters")]
    public string gripParam = "Grip";
    public string triggerParam = "Trigger";

    private Animator anim;

    void Awake() => anim = GetComponent<Animator>();

    void Update()
    {
        if (!controller) return;

        // XRI convention: selectAction = Grip, activateAction = Trigger
        float grip = controller.selectAction.action?.ReadValue<float>() ?? 0f;
        float trig = controller.activateAction.action?.ReadValue<float>() ?? 0f;

        anim.SetFloat(gripParam, grip);
        anim.SetFloat(triggerParam, trig);
    }
}
