using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Craft : MonoBehaviour
{
    GameObject[] InvItem;
    public GameObject Awakener;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InvItem = GameObject.FindGameObjectsWithTag("InvItem");
    }

    public void OnButtonClick()
    {
        if (InvItem.Length == 3)
        {
           Awakener.SetActive(true);
        }
    }
}
