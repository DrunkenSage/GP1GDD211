using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : MonoBehaviour
{
    public GameObject page;
    public GameObject rightarrow;
    public GameObject leftarrow;
    public GameObject button;

    // Update is called once per frame
    public void OnButtonClick()
    {
        page.SetActive(true);
        rightarrow.SetActive(true);
        leftarrow.SetActive(true);
        button.SetActive(false);
        
    }

}
