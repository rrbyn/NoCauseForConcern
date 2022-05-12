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
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update(){
        if(GameEvents.branchesEvent){
            UpdateObjectiveText($"Branches collected {GameEvents.branchCounter}/6");
        }
        if(GameEvents.branchesEventComplete){
            UpdateObjectiveText("Return to the campsite");
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
