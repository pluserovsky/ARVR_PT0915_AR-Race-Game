using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFinishTrigger : MonoBehaviour
{

    private float startTime;
    private float ellpasedTime;
    private bool start = false;
    private int count = 0;
    // Use this for initialization
    void TimerStart()
    {
        startTime = Time.time;
    }// Update is called once per frame
    void Update()
    {
        if (start == true)
        {
            ellpasedTime = Time.time - startTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (count == 0)
        {
            Debug.Log("Start line went in");
            TimerStart();
            ++count;
            start = true;
        }
        else
        {
            Debug.Log("End line went in");
            ellpasedTime = Time.time - startTime;
            count = 0;
            start = false;
        }
    }
    void OnGUI()
    {
        GUI.Label(new Rect(300, 100, 100, 20), (ellpasedTime.ToString()));
    }
}