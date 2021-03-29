using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences;
    public _Dialogue currentDialogue;
    [SerializeField]
    private GameObject skillbox;
    [SerializeField]
    private GameObject dialoguebox;

    // Start is called before the first frame update
    void Start()
    {
       sentences = new Queue<string>(); 
       
    }

    public void StartDialogue (_Dialogue dialogue)
    {
        currentDialogue = dialogue;
        dialoguebox.SetActive(true);
        
        nameText.text = dialogue.name;
        sentences.Clear();
        skillbox.SetActive(false);

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    public void EndDialogue()
    {
        
       dialoguebox.SetActive(false);
      if(currentDialogue.HasSkillOn)
      {
          giveSkillOps();
      }
     
       
    }
    public void giveSkillOps()
    {
        
        skillbox.SetActive(true);
    }
   
}
