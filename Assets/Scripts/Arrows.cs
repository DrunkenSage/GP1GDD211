using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Arrows : MonoBehaviour
{
    public RawImage journalPage;
    public RawImage[] journal;
    public int indexImages;
    

    private void Start()
    {
        journalPage = GetComponent<RawImage>();
        indexImages = 0;
    }
    private void FixedUpdate()
    {
      

        if (Input.GetKey(KeyCode.E))

        {
            Debug.Log(indexImages);
           
            NextImageInArray();
            
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log(indexImages);
            PrevImageInArray();
            
        }
       journalPage = journal[indexImages];

    }
    public void NextImageInArray()
    {
        if (indexImages == journal.Length-1)
        {
            indexImages = 0;
        }
        else
        {
            indexImages++;
            journalPage = journal[indexImages];
        }

    }
    public void PrevImageInArray()
    {
        if (indexImages == 0)
        {
            indexImages = journal.Length;
        }
        else
        {
            indexImages--;
            journalPage = journal[indexImages];
        }
    }
}



