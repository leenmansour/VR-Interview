using UnityEngine;

public class AirplaneLifter : MonoBehaviour
{
    public float liftSpeed = 2f;
    private bool isLifting = false;

    void Update()
    {
        if (isLifting)
        {
            transform.Translate(Vector3.up * liftSpeed * Time.deltaTime);
        }
    }

    public void LiftOff()
    {
        isLifting = true;
    }

    public void StopLift()
    {
        isLifting = false;
    }
}
