using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    public int ChoiceID;
    public GameObject choiceObject;
    public GameObject sisterChoiceObject;
    public bool choiceIsTaken = false;
    
    //public Text textWindow;
    //public GameObject textPanel;

    //public String displayText = "";
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !choiceIsTaken)
        {
            GetComponent<Dialoge>().PlayDialoge();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && !choiceIsTaken)
        {
            //Debug.Log("Choice - Player stays in trigger");
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("Choice " + this.name + ": Enter is pressed");
                choiceIsTaken = true;
                sisterChoiceObject.GetComponent<Choice>().choiceIsTaken = false;
                GetComponent<Dialoge>().disableWindow();
                choiceObject.SetActive(false);
                sisterChoiceObject.SetActive(false);

                GameManager.choiceMade(ChoiceID);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && !choiceIsTaken)
        {
            GetComponent<Dialoge>().disableWindow();
        }
    }

    //private void disableWindow()
    //{
    //    textWindow.gameObject.SetActive(false);
    //    textPanel.SetActive(false);
    //}

    //private void enableWindow()
    //{
    //    textPanel.SetActive(true);
    //    textWindow.text = displayText;
    //    textWindow.gameObject.SetActive(true);
    //}

    /*  Psudocode
     * 
     * OnTriggerEnter
     *  Check if other is player and choiceIsTaken is false
     *      if is player, bring up window
     *  
     * OnTriggerStay
     *  Check if other is player and choiceIsTaken is false
     *      if is player, check for 'Enter' input
     *          if 'Enter' is pressed, change choiceIsTaken to true
     *          
     * 
     * OnTriggerExit
     *  Check if other is player and choiceIsTaken is false
     *      if is player, close window
     * 
     * 
     * 
     */
}
