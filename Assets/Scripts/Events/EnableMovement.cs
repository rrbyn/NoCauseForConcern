using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class EnableMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject cam;
    void OnEnable() {
        cam.SetActive(false);
        GameEvents.canMove = true;
        GameEvents.branchesEvent = true;
    }
}
