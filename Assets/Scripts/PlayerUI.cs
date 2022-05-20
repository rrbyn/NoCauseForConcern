using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI prompText;
    [SerializeField]
    private TextMeshProUGUI objectiveText;
    void Update(){
        if(GameEvents.branchesEvent){
            UpdateObjectiveText($"Branches collected {GameEvents.branchCounter}/6");
        }
        if(GameEvents.branchesEventComplete || GameEvents.bucketEventComplete){
            UpdateObjectiveText("Return to the campsite");
        }
        if(GameEvents.wardsEvent){
            UpdateObjectiveText($"Wards created {GameEvents.wardCounter}/3");
        }
        if(GameEvents.wardsEventComplete){
            UpdateObjectiveText("Go to sleep");
        }
    }

    // Update is called once per frame
    public void UpdatePromptText(string promptMessage)
    {
        prompText.text = promptMessage;
    }
    public void UpdateObjectiveText(string objectiveMessage){
        objectiveText.text = objectiveMessage;
    }
}
