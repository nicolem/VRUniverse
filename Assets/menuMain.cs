using UnityEngine;
using System.Collections;
using System;

public class menuMain : MonoBehaviour
{

    // ....I don't really know what I'm doing here
    public GameObject sun;
    public GameObject earth;
    public GameObject returnButton;

    // Use this for initialization
    void Start()
    {
        Cardboard.Create();

        sun = GameObject.FindGameObjectWithTag("SUN");
        earth = GameObject.FindGameObjectWithTag("EARTH");
        returnButton = GameObject.FindGameObjectWithTag("RETURNBUTTON");

    }

    // Update is called once per frame
    void Update()
    {
        // yoyoyo do nothing
    }

    // hopefully it changes the text color on clicks
    public void sunPress()
    {
        Debug.Log("in sun \n");
        Application.LoadLevel("sun");

    }

    //does the same 
    public void earthPress()
    {
        Debug.Log("in earth \n");
        Application.LoadLevel("earth");

    }

    public void returnToMenuPress()
    {
        Debug.Log("in Main Menu \n");
        Application.LoadLevel("StartMenuScene");

    }
}
