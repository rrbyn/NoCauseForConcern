using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class CampsiteTrigger : MonoBehaviour
{
    public PlayableDirector timeline;
    void Start(){
        timeline = GetComponent<PlayableDirector>();
    }
    void OnTriggerEnter(Collider other) {
        if(GameEvents.branchesEventComplete){
            timeline.Play();
            StartCoroutine(fadeOutAndLoad());
        }
    }

    IEnumerator fadeOutAndLoad(){
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("EatScene");
    }
}
