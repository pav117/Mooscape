using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyGameManager : MonoBehaviour
{
    private static DontDestroyGameManager instance;
    // Start is called before the first frame update
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
