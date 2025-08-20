using UnityEngine;
using UnityEngine.UI;
using TMPro; // <-- ضروري عشان يتعرف على TextMeshProUGUI


public class CountdownTimer : MonoBehaviour
{
    public float timeElapsed = 0f;            // بدأ من 0
    public bool timerIsRunning = false;
    public TextMeshProUGUI timeText;                     // اختياري لعرض الوقت على UI

    void Update()
    {
        if (timerIsRunning)
        {
            timeElapsed += Time.deltaTime;
            UpdateTimeDisplay(timeElapsed);
        }
    }

    public void StartTimer()
    {
        timeElapsed = 0f;
        timerIsRunning = true;
    }

    public void StopTimer()
    {
        timerIsRunning = false;
    }

    void UpdateTimeDisplay(float time)
    {
        if (timeText != null)
        {
            int seconds = Mathf.FloorToInt(time);
            timeText.text = seconds.ToString() + "s";
        }
    }
}
