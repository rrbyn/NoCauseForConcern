using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class EnableMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject crosshair;
    // Start is called before the first frame update
       void OnEnable() {
        crosshair.SetActive(true);
        GameEvents.canMove = true;
    }
}
