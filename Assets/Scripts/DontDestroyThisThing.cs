using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyThisThing : MonoBehaviour
{
    private static DontDestroyThisThing instance;
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
