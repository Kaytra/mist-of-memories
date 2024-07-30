using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingManager : MonoBehaviour
{
    public Text endingText;

    public Text Choice1Text;
    public Text Choice2Text;
    public Text Choice3Text;
    public Text Choice4Text;
    public Text Choice5Text;
    public Text Choice6Text;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("EndingManager - Start: Scene opened");
        // Debug.Log(GameManager.getEndingId());
        displayChoiceResults();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void displayChoiceResults()
    {
        // final result
        if (GameManager.Choice1Taken || GameManager.Choice2Taken || GameManager.Choice3Taken || GameManager.Choice4Taken || GameManager.Choice5Taken || GameManager.Choice6Taken)
        {
            endingText.text = "";

            // choice 1
            if (GameManager.Choice1Taken) // made choice
            {
                if (!GameManager.WhichChoice1) // book
                {
                    Choice1Text.text = "You chose to dedicate your Early Life to study. You were smart; maybe too smart?";
                }
                else if (GameManager.WhichChoice1) // shield
                {
                    Choice1Text.text = "You chose to dedicate your Early Life to training. You were brave; maybe too brave?";
                }
            }
            else if (!GameManager.Choice1Taken) // skipped choice
            {
                Choice1Text.text = "";
            }

            // choice 2
            if (GameManager.Choice2Taken) // made choice
            {
                if (!GameManager.WhichChoice2) // sword
                {
                    Choice2Text.text = "You chose to dedicate your Adolecence to learning how to fight. You were fierce; maybe too fierce?";
                }
                else if (GameManager.WhichChoice2) // feathered cap
                {
                    Choice2Text.text = "You chose to have fun in your Adolecence. You were jovial; maybe too happy?";
                }
            }
            else if (!GameManager.Choice2Taken) // skipped choice
            {
                Choice2Text.text = "";
            }
            
            // choice 3
            if (GameManager.Choice3Taken) // made choice
            {
                if (!GameManager.WhichChoice3) // gold ring
                {
                    Choice3Text.text = "You chose to settle down in your Adulthood. You may have settled, but was it to early and did it last?";
                }
                else if (GameManager.WhichChoice3) // wheel
                {
                    Choice3Text.text = "You chose to explore in you Adulthood. You were adventurous, but at what cost?";
                }
            }
            else if (!GameManager.Choice3Taken) // skipped choice
            {
                Choice3Text.text = "";
            }
            
            // choice 4
            if (GameManager.Choice4Taken) // made choice
            {
                if (!GameManager.WhichChoice4) // child's toy
                {
                    Choice4Text.text = "You chose to have a child in your Mid-Adulthood. Was it with the one you loved or with a passing fling?";
                }
                else if (GameManager.WhichChoice4) // knight's helm
                {
                    Choice4Text.text = "You chose to dedicate your service to a lord in your Mid-Adulthood. Did your vow last, child?";
                }
            }
            else if (!GameManager.Choice4Taken) // skipped choice
            {
                Choice4Text.text = "";
            }
            
            // choice 5
            if (GameManager.Choice5Taken) // made choice
            {
                if (!GameManager.WhichChoice5) // lute
                {
                    Choice5Text.text = "You chose the joy of music in your Old Age. Much joy to be had; but was it a good choice? The right one?";
                }
                else if (GameManager.WhichChoice5) // gold coins
                {
                    Choice5Text.text = "You chose the alure of bits of shiny metal. Was it for a good cause? For the right reason? For the one you loved?";
                }
            }
            else if (!GameManager.Choice5Taken) // skipped choice
            {
                Choice5Text.text = "";
            }
            
            // choice 6
            if (GameManager.Choice6Taken) // made choice
            {
                if (!GameManager.WhichChoice6) // bell
                {
                    Choice6Text.text = "And so the bell tolled upon your passing. Much tears were to be had by those close to you. Were there people close to you, perhaps?";
                }
                else if (GameManager.WhichChoice6) // basket
                {
                    Choice6Text.text = "And so the empty basket lay before you; before you passing. Does it simbolize good? Bad? Misfortune? A life not lived?";
                }
            }
            else if (!GameManager.Choice6Taken) // skipped choice
            {
                Choice6Text.text = "";
            }
        }
        else if (!GameManager.Choice1Taken && !GameManager.Choice2Taken && !GameManager.Choice3Taken && !GameManager.Choice4Taken && !GameManager.Choice5Taken && !GameManager.Choice6Taken)
        {
            Choice1Text.text = "";
            Choice2Text.text = "";
            Choice3Text.text = "";
            Choice4Text.text = "";
            Choice5Text.text = "";
            Choice6Text.text = "";

            endingText.text = "You do not remember any significant events in your life; or perhaps you just do not care. Child, may you rest in peace now...";
        }
    }
}
