using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System;

public class SettingsMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cardboard.Create();
        Cardboard.SDK.VRModeEnabled = ApplicationModel.vrbool;
    }
    [SerializeField]
    Toggle vrmode;

    // Update is called once per frame
    void Update () {
 
	}

    public void returnToMenuPress()
    {
        Debug.Log("in Main Menu \n");
        SceneManager.LoadScene("StartMenuScene");

    }

    /*
    public void turnInfoOnOff(Slider input)
    {

        GameObject[] list = GameObject.FindGameObjectsWithTag("Info");


        //if(textOn)
        if (input.value == 0)
        {
            for (int i = 0; i < list.Length; i++)
            {
                //list[i].SetActive(false);
                list[i].GetComponent<TextMesh>().color = Color.clear;
                Debug.Log("turned off");
            }
            ApplicationModel.infoboxes = false;
        }
        else
        {
            for (int i = 0; i < list.Length; i++)
            {
                //list[i].SetActive(true);
                list[i].GetComponent<TextMesh>().color = Color.white;

                Debug.Log("turned on");
            }
            ApplicationModel.infoboxes = true;
        }
    }
    */
}
