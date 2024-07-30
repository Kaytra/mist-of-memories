using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    private bool optionsMenuOpen = false;
    public GameObject optionsMenu;
    public GameObject mgr;

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "MoM_WorldScene")
        {
            //Debug.Log("Game Manager - In " + SceneManager.GetActiveScene().name);
            
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                // toggle gameMenuOpen
                optionsMenuOpen = !optionsMenuOpen;
            }

            // options menu
            if (optionsMenuOpen)
            {
                // open options menu
                optionsMenu.SetActive(true);
                mgr.GetComponent<GameManager>().togglePlayerMovement(false);
            }
            else if (!optionsMenuOpen)
            {
                // close options menu
                optionsMenu.SetActive(false);
                mgr.GetComponent<GameManager>().togglePlayerMovement(true);
            }
        }
    }
}