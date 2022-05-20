using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BucketEvent : MonoBehaviour
{
    [SerializeField] 
    private GameObject spooky;
    void OnEnable() {
        StartCoroutine(spookyJumpScare());
    }
        IEnumerator spookyJumpScare()
    {
        GameEvents.canMove = false;
        spooky.SetActive(true);
        yield return new WaitForSeconds(1);
        GameEvents.bucketEvent = false;
        GameEvents.bucketEventComplete = true;
        GameEvents.canMove = true;
        spooky.SetActive(false);
    }
}
