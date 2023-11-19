using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateDoor : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("DoorGone");

            foreach(GameObject go in gameObjectArray)
            {
            go.SetActive(false);
            }
    }
}
