using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0;
    float startingTime = 10f;
    //Text in the canvas using UI Text
    //Seralized Field is used so I can see the variable in unity
   [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        if (currentTime > 0)
        {
            //makes timer decrease by one second
            currentTime -= 1 * Time.deltaTime;
            print(currentTime);
            countdownText.text = currentTime.ToString("0");
        }

        if (currentTime >= 3.5f) {
            countdownText.color = Color.black;
        }
        //Change color to red when under 4 seconds
        if (currentTime < 3.5f) {
            countdownText.color = Color.red;
        }

        if (currentTime <= 0)
        {
            //Hides the countdown timer after 1 second
            Invoke("Hide", 1);
        }

    }

    void Hide()
    {
        Destroy(gameObject);
    }
}
