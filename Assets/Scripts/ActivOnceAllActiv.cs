using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivOnceAllActiv : MonoBehaviour
{
    public GameObject L1;
    public GameObject L2;
    public GameObject L3;
    public GameObject L4;
    public GameObject ObjThatDeactivate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (L1.activeInHierarchy && L2.activeInHierarchy && L3.activeInHierarchy && L4.activeInHierarchy)
        {
            ObjThatDeactivate.SetActive(true);
        }
    }
}
