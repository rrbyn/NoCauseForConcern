using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class JumpscareTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject deadBird;
    [SerializeField]
    private GameObject blackScreen;
    [SerializeField]
    private AudioSource audioSource;
    void OnTriggerEnter(Collider other) {
        StartCoroutine(birdJumpScare());
    }
    IEnumerator birdJumpScare(){
        GameEvents.canMove = false;
        blackScreen.SetActive(true);
        deadBird.SetActive(true);
        audioSource.Play();
        yield return new WaitForSeconds(2);
        blackScreen.SetActive(false);
        GameEvents.canMove = true;
        gameObject.SetActive(false);
    }
}
