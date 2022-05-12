using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningCutsceneScript : MonoBehaviour
{
    [SerializeField]
    GameObject title;
    [SerializeField]
    GameObject spooky;
    // Start is called before the first frame update
    void OnEnable() {
        spooky.SetActive(false);
        title.SetActive(true);
    }
}
