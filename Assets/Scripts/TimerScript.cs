using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    public float timer = 0f;
    public GameObject EndScreen;

    void Start()
    {
        StartCoroutine(Timer0());
    }

    private IEnumerator Timer0()
    {
        
        yield return new WaitForSeconds(7);
        StartCoroutine(Timer1());
    }
    private IEnumerator Timer1()
    {
        do
        {
            timer += Time.deltaTime;
            FormatText1();
            yield return null;
        }
        while (timer >= 0);
    }

    public void FormatText1()
    {
        int minutes = (int)(timer / 60) % 60;
        int seconds = (int)(timer % 60);

        timerText.text = "Timer: ";

        if (minutes < 10 && minutes > 0)
        {
            timerText.text += "0";
        }
        if (minutes > 0)
        {
            timerText.text += minutes + " : ";
        }
        if (seconds < 10 && seconds > 0)
        {
            timerText.text += "0";
        }
        if (seconds > 0)
        {
            timerText.text += seconds;
        }
        if (seconds == 0)
        {
            timerText.text += "00";
        }

        if (minutes == 1 && seconds == 32)
        {
            //UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
}
