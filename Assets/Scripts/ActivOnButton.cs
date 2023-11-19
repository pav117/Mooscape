using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivOnButton : MonoBehaviour
{
    public GameObject Activ;
    public GameObject Deactiv;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void whenButtonClicked()
    {
        Activ.SetActive(true);
        Deactiv.SetActive(false);
    }
}
