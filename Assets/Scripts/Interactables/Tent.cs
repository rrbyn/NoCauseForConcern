using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Tent : Interactable
{
    public PlayableDirector timeline;
    void Start(){
        timeline = GetComponent<PlayableDirector>();
    }

    void Update()
    {
        if (GameEvents.wardsEventComplete)
        {
            promptMessage = "Go to sleep";
        }
    }
    protected override void Interact()
    {
        if (GameEvents.wardsEventComplete)
        {
            timeline.Play();
            GameEvents.wardsEventComplete = false;
            GameEvents.wardsPlaced = false;
            StartCoroutine(fadeOutAndLoad());
        }
    }

    IEnumerator fadeOutAndLoad()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("DemoEndScene");
    }
}
