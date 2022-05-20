using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveTextEvent : MonoBehaviour
{
    [SerializeField]
    private GameObject uitext;
    void OnEnable(){
        Destroy(uitext);
    }
}
