using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class PlayerInteract : MonoBehaviour
{
    private GameObject player;
    [SerializeField]
    private float distance = 3f;
    [SerializeField]
    private float height = 1f;
    [SerializeField]
    private LayerMask mask;
    private PlayerUI playerUI;
    private GameObject cam;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        cam = GameObject.Find("PlayerCameraRoot");
        playerUI = GetComponent<PlayerUI>();
    }

    // Update is called once per frame
    void Update()
    {
        playerUI.UpdatePromptText(string.Empty);
        Ray ray = new Ray(cam.transform.position + new Vector3(0f,height,0f) ,cam.transform.forward);
        Debug.DrawRay(ray.origin,ray.direction * distance);
        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo,distance,mask)){
            if (hitInfo.collider.GetComponent<Interactable>() != null){
                playerUI.UpdatePromptText(hitInfo.collider.GetComponent<Interactable>().promptMessage);
                if(Input.GetKeyDown("e")){
                    hitInfo.collider.GetComponent<Interactable>().BaseInteract();
                }
            }
        }
    }
}
