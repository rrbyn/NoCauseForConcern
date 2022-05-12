using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitClearingTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject deadBird;
    void OnTriggerEnter(Collider other) {
        if(GameEvents.branchesEventComplete){
            deadBird.SetActive(false);
        }
    }
}
