using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System;

public class SettingsMenu : MonoBehaviour {
    [SerializeField]
    Toggle vrmode;
    [SerializeField]
    Toggle infoboxes;

    [SerializeField]
    Toggle noboxes;
    [SerializeField]
    Toggle kidsinfo;
    [SerializeField]
    Toggle adultinfo;
    [SerializeField]
    Toggle satireinfo;

    // Use this for initialization
    void Start () {
        Cardboard.Create();
        Cardboard.SDK.VRModeEnabled = ApplicationModel.vrbool;
        vrmode.isOn = ApplicationModel.vrbool;
        noboxes.isOn = !ApplicationModel.infobool;
        kidsinfo.isOn = ApplicationModel.infobool;
        infoboxes.isOn = ApplicationModel.infobool;
    }

    // Update is called once per frame
    void Update () {
        Debug.Log("vr mode: " + vrmode.isOn);
        ApplicationModel.vrbool = vrmode.isOn;
        ApplicationModel.infobool = !noboxes.isOn;
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
