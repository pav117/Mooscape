using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnTemp : MonoBehaviour
{
    [SerializeField] private Transform Player;

    GameObject[] Awakener;

    void Update()
    {
        Awakener = GameObject.FindGameObjectsWithTag("Awakener");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (Awakener.Length == 0)
        {
            if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene(8);
            }
        }
        else if (Awakener.Length == 1)
        {
            ;
        }
    }
}
