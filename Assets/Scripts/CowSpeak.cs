using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowSpeak : MonoBehaviour
{
    public GameObject MooznovS;
    public GameObject MooznovI;
    public GameObject MoodsS;
    public GameObject MoodsI;

    public float sec = 3.0f;

    void Start()
    {
        StartCoroutine(LateCall(sec));
    }

    public void whenButtonClicked()
    {
        MooznovS.SetActive(true);
        MooznovI.SetActive(true);
    }

    IEnumerator LateCall(float seconds)
    {
        if (MooznovS.activeInHierarchy && MooznovI.activeInHierarchy)
            MooznovI.SetActive(false);

        if (MooznovS.activeInHierarchy && MooznovI.activeInHierarchy)
            MooznovS.SetActive(false);

        yield return new WaitForSeconds(seconds);
    }
}
