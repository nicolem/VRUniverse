using UnityEngine;
using System.Collections;

public class setvrmodefalse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	Cardboard.SDK.VRModeEnabled=ApplicationModel.vrbool;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
