using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tent : Interactable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameEvents.branchesEventComplete){
            this.promptMessage = "go to sleep";
        } else {
            this.promptMessage = "";
        }
    }
    protected override void Interact()
    {
        if(GameEvents.branchesEventComplete){
            GameEvents.goToSleep();
        }
    }
}
