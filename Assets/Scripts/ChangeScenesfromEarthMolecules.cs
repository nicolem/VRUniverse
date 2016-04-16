using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScenesfromEarthMolecules : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Cardboard.SDK.VRModeEnabled = ApplicationModel.vrbool;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("StartMenuScene");
        }
    }
}
