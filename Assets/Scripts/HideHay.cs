using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideHay : MonoBehaviour
{
    public GameObject Hide;
    GameObject[] WrenchToHide;
    GameObject[] WrenchStillActive;

    public GameObject MoosonI;
    public GameObject MoosonS;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        WrenchToHide = GameObject.FindGameObjectsWithTag("InvItem");
        WrenchStillActive = GameObject.FindGameObjectsWithTag("HideWrench");
    }
    // Update is called once per frame
    public void whenButtonClicked()
    {
        if (WrenchToHide.Length == 1 && WrenchStillActive.Length == 0)
        {
            StartCoroutine(WrenchBye());

            foreach (GameObject go in WrenchToHide)
            {
                GameObject.Destroy(go);
            }
        }

        if (WrenchToHide.Length == 0 && WrenchStillActive.Length >= 1)
        {
            StartCoroutine(WrenchBye());
            foreach (GameObject go in WrenchStillActive)
            {
                GameObject.Destroy(go);
            }
        }
        else if (WrenchToHide.Length == 0 && WrenchStillActive.Length == 0)
        {
            StartCoroutine(MoosonIA());
            StartCoroutine(MoosonSpeaks());
        }
    }

    public IEnumerator MoosonIA()
    {
        MoosonI.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        MoosonI.SetActive(false);
    }

    public IEnumerator MoosonSpeaks()
    {
        MoosonS.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        MoosonS.SetActive(false);
    }

    public IEnumerator WrenchBye()
    {
        Hide.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        Hide.SetActive(false);
    }
}
