using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantDeactivate : MonoBehaviour
{
    public GameObject Deactivate;
    // Start is called before the first frame update
    void Start()
    {
        Deactivate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
