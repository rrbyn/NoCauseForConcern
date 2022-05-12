using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Branch: Interactable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override void Interact()
    {
        if(GameEvents.branchesEvent){
            GameEvents.collectBranch();
            Destroy(gameObject);
        }
    }
}