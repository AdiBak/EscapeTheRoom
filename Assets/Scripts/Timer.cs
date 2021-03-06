using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject youwin;
    public static float timeRemaining = 60;
    public static bool timerIsRunning = false;
    public Text timeText;

    private void Start()
    {
        // Starts the timer automatically
       // timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                foreach(GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
                {
                    if (gameObj.gameObject.tag != "Finish" && gameObj.gameObject.tag != "player" && gameObj.gameObject.tag != "MainCamera"){
                        Destroy(gameObj.gameObject);
                    }
                }
                if (PlayerCollisions.isOnEnd){
                    youwin.SetActive(true);
                }
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}