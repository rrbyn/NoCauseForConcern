using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using Cinemachine;

public class Bucket : Interactable
{
    [SerializeField] private GameObject spooky;
    [SerializeField] private GameObject cutsceneCamera;
    public PlayableDirector timeline;

    void Update()
    {
        if (GameEvents.bucketEvent)
        {
            promptMessage = "";
        }
    }
    protected override void Interact()
    {
        timeline.Play();
        StartCoroutine(delayDestruction());

    }

    IEnumerator delayDestruction()
    {
        yield return new WaitForSeconds(1);
        GameEvents.bucketEvent = true;
        gameObject.SetActive(false);
    }
}
