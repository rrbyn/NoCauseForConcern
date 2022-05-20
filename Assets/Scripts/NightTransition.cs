using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightTransition : MonoBehaviour
{
    [SerializeField]
    private Material nightSkyBox;
    [SerializeField]
    private Light moon;
    // Start is called before the first frame update
    void OnEnable()
    {
        RenderSettings.skybox = nightSkyBox;
        moon.intensity = 0.06f;
        
    }
}
