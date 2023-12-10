using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOtherWrench : MonoBehaviour
{
    private GameObject OtherWrench;

    void Update()
    {
        OtherWrench = GameObject.FindGameObjectWithTag("Wrench");
        
        if (OtherWrench.activeInHierarchy)
        {
            Destroy(OtherWrench);
        }
    }
}
