using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public static class GameEvents 
{
    public static int branchCounter = 0;
    public static int wardCounter = 0;
    public static bool branchesEventComplete = false;
    public static bool branchesEvent = false;
    public static bool wardsEvent = false;
    public static bool wardsEventComplete = false;
    public static bool canMove = false;
    public static bool wardsPlaced = false;
    public static bool bucketEvent = false;
    public static bool bucketEventComplete = false;
    // Start is called before the first frame update

    public static void collectBranch(){
        if(branchesEvent){
            if(branchCounter < 6){
                branchCounter++;
            }
            if(branchCounter == 6){
                branchesEventComplete = true;
                branchesEvent = false;
            }
        }
    }
    public static void setupWard(){
        if(wardsEvent){
            wardCounter++;
            if(wardCounter == 3){
                wardsPlaced = true;
                wardsEvent = false;
            }
        }
    }
}
