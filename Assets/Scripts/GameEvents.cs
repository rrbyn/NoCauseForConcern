using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public static class GameEvents 
{
    public static int branchCounter = 0;
    public static bool branchesEventComplete = false;
    public static bool branchesEvent = false;
    public static bool canMove = false;
    // Start is called before the first frame update

    public static void collectBranch(){
        if(branchesEvent){
            if(branchCounter < 6){
                branchCounter++;
                Debug.Log("Collected " + branchCounter + "/6 branches");
            }
            if(branchCounter == 6){
                branchesEventComplete = true;
                branchesEvent = false;
            }
        }
    }
    public static void goToSleep(){
        SceneManager.LoadScene("JailScene");
    }
}
