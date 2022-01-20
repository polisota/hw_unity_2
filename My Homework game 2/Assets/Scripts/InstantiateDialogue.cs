using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateDialogue : MonoBehaviour
{
    public GameObject Window;   

    public Text text;
    public Text firstAnswer;
    public Text secondAnswer;
    
    public Button firstButton;
    public Button secondButton;
    

    bool dialogueEnded = false;

    GameObject player;
    public TextAsset ta;

    [SerializeField]
    public int currentNode = 0;
    public int butClicked;
    bool textSet = false;
    Node[] nd;
    Dialogue dialogue;

    void Start()
    {

        secondButton.enabled = false;
        
        Window.SetActive(false);
        player = GameObject.Find("FirstPersonController");
        dialogue = Dialogue.Load(ta);
        nd = dialogue.nodes;


        text.text = nd[currentNode].Npctext;
        firstAnswer.text = nd[currentNode].answers[currentNode].text;

        firstButton.onClick.AddListener(but1);
        secondButton.onClick.AddListener(but2);        

        AnswerClicked(14);  
    }

    private void Update()
    {
        /*
          if (Vector3.Distance(player.transform.position, transform.position) < 1.5f && dialogueEnded == false)
        {
            Window.SetActive(true);
        }
        else
        {
                Window.SetActive(false);

        }
         */


    }

    private void but1()
    {
        butClicked = 0;
        AnswerClicked(0);
    }
    private void but2()
    {
        butClicked = 1;
        AnswerClicked(1);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Window.SetActive(true);

        }
    }

   
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Window.SetActive(false);

        }
    }


    public void AnswerClicked(int numberOfButton)
    {

        if (numberOfButton == 14)
            currentNode = 0;
        else
        {
            if (dialogue.nodes[currentNode].answers[numberOfButton].end == "true")
            {
                dialogueEnded = true;
                Window.SetActive(false);
            }
                
           currentNode = dialogue.nodes[currentNode].answers[numberOfButton].nextNode;
        }

        

        text.text = dialogue.nodes[currentNode].Npctext;

        firstAnswer.text = dialogue.nodes[currentNode].answers[0].text;
        if (dialogue.nodes[currentNode].answers.Length == 2)
        {
            secondButton.enabled = true;
            secondAnswer.text = dialogue.nodes[currentNode].answers[1].text;
        }
        else {
            secondButton.enabled = false;
            secondAnswer.text = "";
        }

        


    }

}
