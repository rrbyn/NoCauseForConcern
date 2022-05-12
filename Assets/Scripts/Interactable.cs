using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string promptMessage;

    public void BaseInteract()
    {
        Interact();
    }

    // Update is called once per frame
    protected virtual void Interact()
    {
        
    }
}
