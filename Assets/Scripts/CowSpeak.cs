using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowSpeak : MonoBehaviour
{
    public GameObject MooznovS;
    public GameObject MooznovI;

    public GameObject MoodsS;
    public GameObject MoodsI;

    public GameObject MooznovAS;

    public GameObject MoodsAS;

    public GameObject CowManager;

    GameObject[] Awakener;

    void Start()
    {

    }

    void Update()
    {
       Awakener = GameObject.FindGameObjectsWithTag("Awakener"); 
    }

    public void whenButtonClicked1()
    {
        if (Awakener.Length == 0)
        {
            StartCoroutine(MooZSpeak1());
            StartCoroutine(MooZIcon());
        }
        else if (Awakener.Length >= 1)
        {
            StartCoroutine(MooZSpeak2());
            StartCoroutine(MooZIcon());
            CowManager.SetActive(true);

        }
    }

    public void whenButtonClicked2()
    {
        if (Awakener.Length == 0)
        {
            StartCoroutine(MooDSpeak1());
            StartCoroutine(MooDIcon());
        }
        else if (Awakener.Length >= 1)
        {
            StartCoroutine(MooDSpeak2());
            StartCoroutine(MooDIcon());
            CowManager.SetActive(true);
        }
    }


    public IEnumerator MooZSpeak1()
    {
        MooznovS.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        MooznovS.SetActive(false);
    }

    public IEnumerator MooZIcon()
    {
        MooznovI.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        MooznovI.SetActive(false);
    }

    public IEnumerator MooZSpeak2()
    {
        MooznovAS.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        MooznovAS.SetActive(false);
    }

    public IEnumerator MooDSpeak1()
    {
        MoodsS.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        MoodsS.SetActive(false);
    }

    public IEnumerator MooDIcon()
    {
        MoodsI.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        MoodsI.SetActive(false);
    }

    public IEnumerator MooDSpeak2()
    {
        MoodsAS.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        MoodsAS.SetActive(false);
    }
}
