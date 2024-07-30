using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public GameObject player;
    
    public static bool Choice1Taken = false;
    public static bool WhichChoice1;
    public static bool Choice2Taken = false;
    public static bool WhichChoice2;
    public static bool Choice3Taken = false;
    public static bool WhichChoice3;
    public static bool Choice4Taken = false;
    public static bool WhichChoice4;
    public static bool Choice5Taken = false;
    public static bool WhichChoice5;
    public static bool Choice6Taken = false;
    public static bool WhichChoice6;

    static string EndingId = "";
    private static bool EndingIDGenerated = false;

    //private bool optionsMenuOpen = false;

    void Awake()
    {
        // Keep Tracker in all scenes
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*
        if (SceneManager.GetActiveScene().name == "MoM_WorldScene")
        {
            //Debug.Log("Game Manager - In " + SceneManager.GetActiveScene().name);

            // get the options menu
            GameObject optionsMenu = GameObject.Find("OptionsMenu_Canvas");

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                // toggle gameMenuOpen
                optionsMenuOpen = !optionsMenuOpen;
            }
            //else if (Input.GetMouseButtonDown(0) && optionsMenuOpen)
            //{
            //    optionsMenuOpen = false; 
            //}

            if (optionsMenuOpen)
            {
                // open options menu
                optionsMenu.SetActive(true);
            }
            else if (!optionsMenuOpen)
            {
                // close options menu
                optionsMenu.SetActive(false);
            }
        }
        */
    }

    /* Swap scenes psudocode/placeholder
     * 
     */
    

    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        // Debug.Log("Active Scene: " + SceneManager.GetActiveScene().name);
    }

    public static void loadSceneS(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        // Debug.Log("Active Scene: " + SceneManager.GetActiveScene().name);
    }

    public void quitGame()
    {
        Application.Quit();
    }
    
    public static void generateEndingId()
    {
        if (!EndingIDGenerated)
        {
            // choice 1
            if (!Choice1Taken)
            {
                EndingId += "00";
            }
            else if (Choice1Taken)
            {
                if (!WhichChoice1)
                {
                    EndingId += "01";
                }
                else if (WhichChoice1)
                {
                    EndingId += "02";
                }
            }

            // choice 2
            if (!Choice2Taken)
            {
                EndingId += "00";
            }
            else if (Choice2Taken)
            {
                if (!WhichChoice2)
                {
                    EndingId += "03";
                }
                else if (WhichChoice2)
                {
                    EndingId += "04";
                }
            }

            // choice 3
            if (!Choice3Taken)
            {
                EndingId += "00";
            }
            else if (Choice3Taken)
            {
                if (!WhichChoice3)
                {
                    EndingId += "05";
                }
                else if (WhichChoice3)
                {
                    EndingId += "06";
                }
            }

            // choice 4
            if (!Choice4Taken)
            {
                EndingId += "00";
            }
            else if (Choice4Taken)
            {
                if (!WhichChoice4)
                {
                    EndingId += "07";
                }
                else if (WhichChoice4)
                {
                    EndingId += "08";
                }
            }

            // choice 5
            if (!Choice5Taken)
            {
                EndingId += "00";
            }
            else if (Choice5Taken)
            {
                if (!WhichChoice5)
                {
                    EndingId += "09";
                }
                else if (WhichChoice5)
                {
                    EndingId += "10";
                }
            }

            // choice 6
            if (!Choice6Taken)
            {
                EndingId += "00";
            }
            else if (Choice6Taken)
            {
                if (!WhichChoice6)
                {
                    EndingId += "11";
                }
                else if (WhichChoice6)
                {
                    EndingId += "12";
                }
            }

            EndingIDGenerated = true;
        }

        //Debug.Log("Game Manager - generateEndingId() - EndingID: " + EndingId);
    }
    
    public static string getEndingId()
    {
        return EndingId;
    }

    void updateColor()
    {
        //player.GetComponent<PlayerColor>.updateColor();
    }

    public void togglePlayerMovement(bool input)
    {
        player.GetComponent<PlayerController>().togglePlayerMovement(input);
    }

    public static void choiceMade(int ChoiceID)
    {
        if (ChoiceID == 1 || ChoiceID == 2)
        {
            Choice1Taken = true;
            if (ChoiceID == 1)
            {
                WhichChoice1 = false;
            }
            else if (ChoiceID == 2)
            {
                WhichChoice1 = true;
            }
        }
        else if (ChoiceID == 3 || ChoiceID == 4)
        {
            Choice2Taken = true;
            if (ChoiceID == 3)
            {
                WhichChoice2 = false;
            }
            else if (ChoiceID == 4)
            {
                WhichChoice2 = true;
            }
        }
        else if (ChoiceID == 5 || ChoiceID == 6)
        {
            Choice3Taken = true;
            if (ChoiceID == 5)
            {
                WhichChoice3 = false;
            }
            else if (ChoiceID == 6)
            {
                WhichChoice3 = true;
            }
        }
        else if (ChoiceID == 7 || ChoiceID == 8)
        {
            Choice4Taken = true;
            if (ChoiceID == 7)
            {
                WhichChoice4 = false;
            }
            else if (ChoiceID == 8)
            {
                WhichChoice4 = true;
            }
        }
        else if (ChoiceID == 9 || ChoiceID == 10)
        {
            Choice5Taken = true;
            if (ChoiceID == 9)
            {
                WhichChoice5 = false;
            }
            else if (ChoiceID == 10)
            {
                WhichChoice5 = true;
            }
        }
        else if (ChoiceID == 11 || ChoiceID == 12)
        {
            Choice6Taken = true;
            if (ChoiceID == 11)
            {
                WhichChoice6 = false;
            }
            else if (ChoiceID == 12)
            {
                WhichChoice6 = true;
            }
        }
    }
}
