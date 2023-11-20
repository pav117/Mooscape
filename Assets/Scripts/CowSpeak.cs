using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowSpeak : MonoBehaviour
{
    public GameObject MooznovS;
    public GameObject MooznovI;

    void Start()
    {

    }

    public void whenButtonClicked()
    {
        StartCoroutine(MooZSpeak());
        StartCoroutine(MooZIcon());
    }

    public IEnumerator MooZSpeak()
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
}
