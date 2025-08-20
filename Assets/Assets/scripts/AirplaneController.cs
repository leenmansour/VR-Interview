using UnityEngine;

public class AirplaneController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private bool isMoving = false;

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }

    public void StartMoving()
    {
        isMoving = true;
    }

    public void StopMoving()
    {
        isMoving = false;
    }
}
