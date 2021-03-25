using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public Text interactWithMeText;
    public Transform player;
    


    private bool isNear = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            reactwithObject();
           

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("In Range");
        isNear = true;
        interactWithMeText.text = "Press F";
    }

    public void reactwithObject()
    {
        if (isNear)
        {
            // Debug.Log("Interacting");
            // if (player.GetComponent<FpsControllerLPFP>().keycardActive)
            // {
            //     Debug.Log("open says me");
            //     openDoor.SetBool("character_nearby", true);
            // }
            
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        isNear = false;
        //Debug.Log("Walked Away");
        interactWithMeText.text = "";

    }

}
