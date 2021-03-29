using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class False : MonoBehaviour
{
    public GameObject page;
    public GameObject rightarrow;
    public GameObject leftarrow;
    public GameObject button;

    // Update is called once per frame
    public void OnButtonClick()
    {
        page.SetActive(false);
        rightarrow.SetActive(false);
        leftarrow.SetActive(false);
        button.SetActive(true);
    }
}
