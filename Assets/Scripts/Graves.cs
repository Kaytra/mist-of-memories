using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Graves : MonoBehaviour
{

    int counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && counter > 0)
        {
            if (Input.GetKey(KeyCode.E))
            {
                counter--;
                //Debug.Log("Graves - counter: " + counter);
            }
        }
        else if (other.tag == "Player" && counter == 0)
        {
            Debug.Log("open gate");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            counter = GetComponent<Dialoge>().getDialogeArraySize();
            //Debug.Log("Graves Script: Player entered trigger");
            GetComponent<Dialoge>().PlayDialoge();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<Dialoge>().disableWindow();
        }
    }
}
