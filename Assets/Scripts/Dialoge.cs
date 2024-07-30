using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialoge : MonoBehaviour
{
    public string[] DialogeLines;
    public bool isChoice = false;

    private bool doingDialoge = false;
    private int i = 0;

    public Text textWindow;
    public Text subtextWindow;
    public GameObject textPanel;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doingDialoge && i < DialogeLines.Length && !isChoice)
        {
            //Debug.Log("Dialoge - is doing dialoge");
            textWindow.text = DialogeLines[i];
            if (Input.GetKeyDown(KeyCode.E))
            {
                i++;
            }
        }
        else if (doingDialoge && i >= DialogeLines.Length && !isChoice)
        {
            //Debug.Log("Dialoge - is disabling window");
            disableWindow();
        }
        else if (doingDialoge && isChoice)
        {
            // Debug.Log("Dialoge - choice window");
            textWindow.text = DialogeLines[i];
        }
    }

    public void PlayDialoge()
    {
        // enable text object and panel
        enableWindow();
    }
    
    public void disableWindow()
    {
        //Debug.Log("Dialoge Script: Disabled Window");
        textWindow.gameObject.SetActive(false);
        textPanel.SetActive(false);
        doingDialoge = false;
        i = 0;
    }

    private void enableWindow()
    {
        //Debug.Log("Dialoge Script: Enabled Window");
        doingDialoge = true;
        textPanel.SetActive(true);
        textWindow.gameObject.SetActive(true);
        if (isChoice)
        {
            subtextWindow.text = "Press 'Enter' to select";
        }
        else if (!isChoice)
        {
            subtextWindow.text = "Press 'E' to continue";
        }
    }

    public int getDialogeArraySize()
    {
        return DialogeLines.Length;
    }
}
