﻿using UnityEngine;
using UnityEngine.SceneManagement;
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

        Cardboard.SDK.VRModeEnabled = ApplicationModel.vrbool;
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
        SceneManager.LoadScene("sun");

    }

    //does the same 
    public void earthPress()
    {
        Debug.Log("in earth \n");
        SceneManager.LoadScene("earth");

    }


    public void mercuryPress()
    {
        Debug.Log("in mercury \n");
        SceneManager.LoadScene("mercury");

    }

    public void venusPress()
    {
        Debug.Log("in venus \n");
        SceneManager.LoadScene("venus");

    }


    public void marsPress()
    {
        Debug.Log("in mars \n");
        SceneManager.LoadScene("mars");

    }

    public void jupiterPress()
    {
        Debug.Log("in jupiter \n");
        SceneManager.LoadScene("jupiter");

    }


    public void saturnPress()
    {
        Debug.Log("in saturn \n");
        SceneManager.LoadScene("saturn");

    }


    public void uranusPress()
    {
        Debug.Log("in uranus \n");
        SceneManager.LoadScene("uranus");

    }


    public void neptunePress()
    {
        Debug.Log("in neptune \n");
        SceneManager.LoadScene("neptune");

    }


    public void plutoPress()
    {
        Debug.Log("in pluto \n");
        SceneManager.LoadScene("pluto");

    }







    public void returnToMenuPress()
    {
        Debug.Log("in Main Menu \n");
        SceneManager.LoadScene("StartMenuScene");

    }
}
