using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateColor(float pColor1, float pColor2, float pColor3)
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(pColor1, pColor2, pColor3);
    }
}
