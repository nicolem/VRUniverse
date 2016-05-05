using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScenesfromMercury : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Cardboard.SDK.VRModeEnabled = ApplicationModel.vrbool;

        GameObject[] list = GameObject.FindGameObjectsWithTag("Info");
        for (int i = 0; i < list.Length; i++)
        {
            if (ApplicationModel.infobool)
                list[i].GetComponent<TextMesh>().color = Color.white;
            else
                list[i].GetComponent<TextMesh>().color = Color.clear;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("MercuryMolecules");
        }
    }
}

