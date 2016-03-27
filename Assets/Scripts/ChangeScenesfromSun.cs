using UnityEngine;
using System.Collections;

public class ChangeScenesfromSun : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cardboard.SDK.VRModeEnabled = ApplicationModel.vrbool;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("SunParticles");
        }
    }
}
