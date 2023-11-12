using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideHay : MonoBehaviour
{
    public GameObject Hide;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void whenButtonClicked()
    {
        if (Hide.activeInHierarchy == true)
            Hide.SetActive(false);
        else
            Hide.SetActive(true);
    }
}
