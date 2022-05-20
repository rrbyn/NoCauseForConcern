using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndEatScene : MonoBehaviour
{
    [SerializeField]
    private GameObject schafer;
    [SerializeField]
    private GameObject moorman;
    [SerializeField]
    private GameObject schaferTent;
    [SerializeField]
    private GameObject moormanTent;
    [SerializeField]
    private GameObject schaferTentClosed;
    [SerializeField]
    private GameObject moormanTentClosed;
    // Start is called before the first frame update
    void OnEnable()
    {
        schafer.SetActive(false);
        moorman.SetActive(false);
        schaferTent.SetActive(false);
        moormanTent.SetActive(false);
        schaferTentClosed.SetActive(true);
        moormanTentClosed.SetActive(true);

        GameEvents.wardsEvent = true;
    }

    // Update is called once per frame
}
