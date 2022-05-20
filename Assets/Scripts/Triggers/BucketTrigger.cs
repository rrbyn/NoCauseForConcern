using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject fallenTree;
    [SerializeField]
    private GameObject schafer;
    [SerializeField]
    private GameObject junk;
    void OnTriggerEnter(Collider other)
    {
        if(GameEvents.bucketEventComplete){
            fallenTree.SetActive(false);
            junk.SetActive(false);
            schafer.SetActive(false);
        }
    }
}
