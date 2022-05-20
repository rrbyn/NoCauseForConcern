using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFire : MonoBehaviour
{
    [SerializeField]
    private GameObject fire;
    void OnEnable()
    {
        fire.GetComponent<AudioSource>().Play();
    }
}
