using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using Cinemachine;

public class Ward : Interactable
{
    [SerializeField] private GameObject spooky;
    [SerializeField] private GameObject cutsceneCamera;
    [SerializeField] private Transform target;
    private bool set = false;

    void Update()
    {
        if (GameEvents.wardsEvent && !set)
        {
            promptMessage = "Create ward";
        }
        else
        {
            promptMessage = "";
        }
    }

    protected override void Interact()
    {
        if (GameEvents.wardsEvent && !set)
        {
            GameEvents.setupWard();
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            set = true;
            GetComponent<AudioSource>().volume = 0.25f * GameEvents.wardCounter;
            GetComponent<AudioSource>().Play();
            if (GameEvents.wardsPlaced)
            {

                StartCoroutine(spookyJumpScare());

            }
        }
    }
    IEnumerator spookyJumpScare()
    {
        GameEvents.canMove = false;
        spooky.SetActive(true);
        spooky.transform.LookAt(target);
        cutsceneCamera.SetActive(true);
        cutsceneCamera.GetComponent<CinemachineVirtualCamera>().enabled = true;
        cutsceneCamera.GetComponent<CinemachineVirtualCamera>().LookAt = spooky.transform;
        spooky.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(8);
        GameEvents.wardsEventComplete = true;
        GameEvents.canMove = true;
        spooky.SetActive(false);
        cutsceneCamera.SetActive(false);
        cutsceneCamera.GetComponent<CinemachineVirtualCamera>().enabled = false;
        spooky.GetComponent<AudioSource>().Stop();
    }

}

