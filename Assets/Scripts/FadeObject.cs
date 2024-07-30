using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Credit to link below for splaining how to faid a game object
 * https://owlcation.com/stem/How-to-fade-out-a-GameObject-in-Unity
 * 
 * 
 */


public class FadeObject : MonoBehaviour
{
    public float fadeSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeOut(GameObject obj)
    {
        StartCoroutine(FadeOutObject(obj));
    }

    public void FadeIn(GameObject obj)
    {
        StartCoroutine(FadeInObject(obj));
    }


    public IEnumerator FadeOutObject(GameObject obj)
    {
        while (obj.GetComponent<Renderer>().material.color.a > 0)
        {
            Color objectColor = obj.GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            obj.GetComponent<Renderer>().material.color = objectColor;
            yield return null;
        }
    }

    public IEnumerator FadeInObject(GameObject obj)
    {
        while (obj.GetComponent<Renderer>().material.color.a > 0)
        {
            Color objectColor = obj.GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            obj.GetComponent<Renderer>().material.color = objectColor;
            yield return null;
        }
    }
}
