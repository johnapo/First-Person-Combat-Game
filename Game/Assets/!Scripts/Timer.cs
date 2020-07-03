using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool endGame;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        endGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (endGame)
        {
            return;
        }

        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;

    }

    public void stopTimer()
    {
        endGame = true;
        timerText.color = Color.black;
    }
}
