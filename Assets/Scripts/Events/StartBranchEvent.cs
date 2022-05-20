using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBranchEvent : MonoBehaviour
{
    void OnEnable()
    {
        GameEvents.branchesEvent = true;
    }
}
