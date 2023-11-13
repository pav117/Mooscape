using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionBackToStealth : MonoBehaviour
{
    public DoorData transitionInformation;
    public TransitionData currentTransitionManager;

    public void TransitionFunction()
    {
        if (transitionInformation != null)
        {
            currentTransitionManager.currentDoorTransition = transitionInformation;
            currentTransitionManager.transiting = true;

            SceneManager.LoadScene(transitionInformation.targetSceneName);
        }
    }
}
