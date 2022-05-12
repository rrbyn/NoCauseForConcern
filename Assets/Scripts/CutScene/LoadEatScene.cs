using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEatScene : MonoBehaviour
{
    // Start is called before the first frame update
     void OnEnable() {
        SceneManager.LoadScene("EatScene");
    }
}