using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrenchSpawn : MonoBehaviour
{
    GameObject[] WrenchToHide;
    GameObject[] WrenchStillActive;

    public GameObject WSpawn;
    public GameObject W2Spawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WrenchToHide = GameObject.FindGameObjectsWithTag("InvItem");
        WrenchStillActive = GameObject.FindGameObjectsWithTag("HideWrench");
    }

    public void SpawnIt()
    {
        if (WrenchToHide.Length == 1 && WrenchStillActive.Length == 0)
        {
            GameObject tempWrench = Instantiate(WSpawn, transform.position, Quaternion.identity);
        }

        else if (WrenchToHide.Length == 0 && WrenchStillActive.Length >= 1)
        {
            GameObject tempWrenchTwo = Instantiate(W2Spawn, transform.position, Quaternion.identity);
        }    
    }
}
