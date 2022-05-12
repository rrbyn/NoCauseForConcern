using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMovement : MonoBehaviour
{
    // Start is called before the first frame update
       void OnEnable() {
        GameEvents.canMove = false;
    }
}
