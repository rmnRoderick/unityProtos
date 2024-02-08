using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Text timerText;
    float elapsedTime = 0;

    void Start()
    {
        timerText = GetComponent<Text>();
    }

    public void Reset()
    {
        elapsedTime = 0;
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        timerText.text = Mathf.Round(elapsedTime).ToString();
    }
}
