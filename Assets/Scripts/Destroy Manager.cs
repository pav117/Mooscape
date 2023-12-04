using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyManager : MonoBehaviour
{
    GameObject[] InvItem;
    private GameObject TimeManager;
    private GameObject ButtonManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeManager = GameObject.FindGameObjectWithTag("TimeManager");
        ButtonManager = GameObject.FindGameObjectWithTag("ButtonManager");

        InvItem = GameObject.FindGameObjectsWithTag("InvItem");

        foreach(GameObject go in InvItem)
        {
            GameObject.Destroy(go);
        }

        if (TimeManager.activeInHierarchy)
        {
            Destroy(TimeManager);
        }

        if (ButtonManager.activeInHierarchy)
        {
            Destroy(ButtonManager);
        }
        
        
    }
}
