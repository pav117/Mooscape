using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Timeline.Actions.MenuPriority;

public class TransitionBackToStealth : MonoBehaviour
{
    public DoorData transitionInformation;
    public TransitionData currentTransitionManager;

    public AddTime addTime;

    public void TransitionFunction()
    {
        if (transitionInformation != null)
        {
            currentTransitionManager.currentDoorTransition = transitionInformation;
            currentTransitionManager.transiting = true;

            GameObject addTimeGameObject = GameObject.FindGameObjectWithTag("TimeManager");
            addTime = addTimeGameObject.GetComponent<AddTime>();
            if (addTime != null)
            {
                addTime.score = addTime.score + 1;
                print(addTime.score);
            }

            SceneManager.LoadScene(transitionInformation.targetSceneName);
        }
    }
}
