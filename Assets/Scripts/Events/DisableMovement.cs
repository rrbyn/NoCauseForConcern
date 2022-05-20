using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject crosshair;
    // Start is called before the first frame update
       void OnEnable() {
        crosshair.SetActive(false);
        GameEvents.canMove = false;
    }
}
