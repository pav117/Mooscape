using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateAlien : MonoBehaviour
{
    public GameObject Alien;

    public GameObject RevengeSpeak;
    public GameObject Icon;

    private GameObject CowManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CowManager = GameObject.FindGameObjectWithTag("CowManager");
    }

    public void whenButtonClicked()
    {
        if (CowManager.activeInHierarchy)
        {
            StartCoroutine(RetributionS());
            StartCoroutine(RetributionI());
            Destroy(Alien);
        }
    }

    public IEnumerator RetributionS()
    {
        RevengeSpeak.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        RevengeSpeak.SetActive(false);
    }

    public IEnumerator RetributionI()
    {
        Icon.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        Icon.SetActive(false);
    }
}
