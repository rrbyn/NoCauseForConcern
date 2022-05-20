using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGameEvent : MonoBehaviour
{
    public void OnEnable()
    {
        Application.Quit();
    }
}
