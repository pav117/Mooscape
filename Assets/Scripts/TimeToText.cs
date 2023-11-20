using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeToText : MonoBehaviour
{
    public AddTime addTime;
    public Text time;

    public void Start()
    {
        GameObject addTimeGameObject = GameObject.FindGameObjectWithTag("TimeManager");
        addTime = addTimeGameObject.GetComponent<AddTime>();

    }

    public void Update()
    {
        GameObject timeGameObject = GameObject.FindGameObjectWithTag("Time");
        time = timeGameObject.GetComponent<Text>();

        time.text = addTime.score.ToString();
    }
}
