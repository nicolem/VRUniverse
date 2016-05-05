using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class menuMain : MonoBehaviour
{




    // Use this for initialization
    void Start()
    {
        Cardboard.Create();
        Cardboard.SDK.VRModeEnabled = ApplicationModel.vrbool;
    }

    // Update is called once per frame
    void Update()
    {
        // yoyoyo do nothing
    }

    /*

    void OnGazeStart()
    {
        GameObject light = this.transform.GetChild(0).gameObject;

        if (light != null)
        {

            light.GetComponent<Light>().intensity = 8;

            bool onOrOff = light.GetComponent<Light>().isActiveAndEnabled;
            string name = light.name;

            Debug.Log("Lights On");
            Debug.Log(name);
            Debug.Log(onOrOff);

        }
        else
        {
            Debug.Log("Lights not turned on");
        }
    }

    void OnGazeExit()
    {
        GameObject light = this.transform.GetChild(0).gameObject;


        if (light != null)
        {
            light.GetComponent<Light>().intensity = 0;

            bool onOrOff = light.GetComponent<Light>().isActiveAndEnabled;
            string name = light.name;

            Debug.Log("Lights Off");
            Debug.Log(name);
            Debug.Log(onOrOff);
        }
        else
        {
            Debug.Log("Lights not turned off");
        }
        //light.SetActive(false);
    }

    */
    //goes to the sun scene on click
    public void sunPress()
    {
        Debug.Log("in sun \n");
        SceneManager.LoadScene("Sun");

    }

    //does the same but for appropriate solar system object
    public void earthPress()
    {
        Debug.Log("in earth \n");
        SceneManager.LoadScene("Earth");

    }


    public void mercuryPress()
    {
        Debug.Log("in mercury \n");
        SceneManager.LoadScene("Mercury");

    }

    public void venusPress()
    {
        Debug.Log("in venus \n");
        SceneManager.LoadScene("Venus");

    }


    public void marsPress()
    {
        Debug.Log("in mars \n");
        SceneManager.LoadScene("Mars");

    }

    public void jupiterPress()
    {
        Debug.Log("in jupiter \n");
        SceneManager.LoadScene("Jupiter");

    }


    public void saturnPress()
    {
        Debug.Log("in saturn \n");
        SceneManager.LoadScene("Saturn");

    }


    public void uranusPress()
    {
        Debug.Log("in uranus \n");
        SceneManager.LoadScene("Uranus");

    }


    public void neptunePress()
    {
        Debug.Log("in neptune \n");
        SceneManager.LoadScene("Neptune");

    }


    public void plutoPress()
    {
        Debug.Log("in pluto \n");
        SceneManager.LoadScene("Pluto");

    }


    public void returnToMenuPress()
    {
        Debug.Log("in Main Menu \n");
        SceneManager.LoadScene("StartMenuScene");

    }

    public void settingsMenuPress()
    {
        Debug.Log("in settingsMenu \n");
        SceneManager.LoadScene("SettingsMenuScene");

    }
}
