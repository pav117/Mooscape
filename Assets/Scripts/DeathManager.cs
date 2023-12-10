using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    GameObject[] Aliens;
    public GameObject Ending2Trigger;

    void Start()
    {
        
    }

    void Update()
    {
        Aliens = GameObject.FindGameObjectsWithTag("Alien");

        if (Aliens.Length == 0)
        {
            Ending2Trigger.SetActive(true);
        }
    }
}
