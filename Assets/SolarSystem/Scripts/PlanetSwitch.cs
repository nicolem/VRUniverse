using UnityEngine;
using System.Collections;

public class PlanetSwitch : MonoBehaviour {
	GameObject MercuryCamera;
	GameObject VenusCamera;
	GameObject EarthCamera;
	GameObject MoonCamera;
	GameObject MarsCamera;
	GameObject JupiterCamera;
	GameObject SaturnCamera;
	GameObject UranusCamera;
	GameObject NeptunCamera;
	GameObject SunCamera;
	GameObject Earth;
	GameObject EarthNight;
    GameObject MainCamera;

	bool Move = false;
	bool showMenu = true;
	string showMenuText = "Hide";


	public GUISkin guiSkin;

	public string planetName;

	public float baseDistant = 2.5f;
	public float baseScrolSpeed = 0.1f;

	public Light SunLight;
   

	// Use this for initialization
	void Start () {
		MercuryCamera = GameObject.FindGameObjectWithTag("MercuryCam");
		EarthCamera = GameObject.FindGameObjectWithTag("EarthCam");

		VenusCamera = GameObject.FindGameObjectWithTag("VenusCam");
		MoonCamera = GameObject.FindGameObjectWithTag("MoonCam");
		MarsCamera = GameObject.FindGameObjectWithTag("MarsCam");
		JupiterCamera = GameObject.FindGameObjectWithTag("JupiterCam");
		SaturnCamera = GameObject.FindGameObjectWithTag("SaturnCam");
		SunCamera = GameObject.FindGameObjectWithTag("SunCam");
		UranusCamera = GameObject.FindGameObjectWithTag("UranusCam");
		NeptunCamera = GameObject.FindGameObjectWithTag("NeptunCam");

		Earth = GameObject.FindGameObjectWithTag("Earth");
		EarthNight = GameObject.FindGameObjectWithTag("EarthNight");
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");


	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI () {

		GUI.skin = guiSkin;

		if(GUI.Button(new Rect(20,Screen.height/2 + 200,100,40), showMenuText) && !Move) {
			if(showMenu)
			{
				showMenuText = "Show";
				showMenu = false;
			}
			else
			{
				showMenuText = "Hide";
				showMenu = true;
			}
		}
		if(showMenu)
			{
			GUI.Label(new Rect(Screen.width/2 + 40, 60,500,200), planetName);


			if(GUI.Button(new Rect(20,60,100,40), "Mercury")) {
				AssignPlanetCameraCoordinates(MercuryCamera, "Mercury");
				}
			

			if(GUI.Button(new Rect(20,100,100,40), "Venus")) {
				AssignPlanetCameraCoordinates(VenusCamera, "Venus");
			}

			if(GUI.Button(new Rect(20,140,100,40), "Earth")) {
				AssignPlanetCameraCoordinates(EarthCamera, "Earth");
				Earth.GetComponent<Renderer>().enabled = true;
				EarthNight.GetComponent<Renderer>().enabled = false;

			}

			if(GUI.Button(new Rect(120,140,100,40), "Earth Night")) {
				AssignPlanetCameraCoordinates(EarthCamera, "Earth");
				Earth.GetComponent<Renderer>().enabled = false;
				EarthNight.GetComponent<Renderer>().enabled = true;
			}

			if(GUI.Button(new Rect(220,140,100,40), "Moon")) {
				AssignPlanetCameraCoordinates(MoonCamera, "Moon");
			}

			if(GUI.Button(new Rect(20,180,100,40), "Mars")) {
				AssignPlanetCameraCoordinates(MarsCamera, "Mars");
			}

			if(GUI.Button(new Rect(20,220,100,40), "Jupiter")) {
				AssignPlanetCameraCoordinates(JupiterCamera, "Jupiter");
			}

			if(GUI.Button(new Rect(20,260,100,40), "Saturn")) {
				AssignPlanetCameraCoordinates(SaturnCamera, "Saturn");

				//Mathf.Lerp(gameObject.transform.position.x, JupiterCamera.transform.position.x, Time.time);
			}

			if(GUI.Button(new Rect(20,300,100,40), "Uranus")) {
				AssignPlanetCameraCoordinates(UranusCamera, "Uranus");
				
				//Mathf.Lerp(gameObject.transform.position.x, JupiterCamera.transform.position.x, Time.time);
			}

			if(GUI.Button(new Rect(20,340,100,40), "Neptune")) {
				AssignPlanetCameraCoordinates(NeptunCamera, "Neptune");
				
				//Mathf.Lerp(gameObject.transform.position.x, JupiterCamera.transform.position.x, Time.time);
			}

			if(GUI.Button(new Rect(20,380,100,40), "Sun")) {
				AssignPlanetCameraCoordinates(SunCamera, "Sun");
				
				//Mathf.Lerp(gameObject.transform.position.x, JupiterCamera.transform.position.x, Time.time);
			}
		}
	}

	void AssignPlanetCameraCoordinates (GameObject currentPlanet, string selectedPlanetName)
	{
		planetName = selectedPlanetName;
		//gameObject.transform.position = currentPlanet.transform.position;
		//gameObject.transform.rotation = currentPlanet.transform.rotation;

        GameObject planet = GameObject.Find(selectedPlanetName);

		MainCamera.GetComponent<RotationAroundPlanet>().target = planet.transform;

		MainCamera.GetComponent<RotationAroundPlanet>().distance = baseDistant * planet.transform.localScale.x;
        MainCamera.GetComponent<RotationAroundPlanet>().MouseWheelSensitivity = baseScrolSpeed * planet.transform.localScale.x;

		// Switch off flare if sun is selected

		if(selectedPlanetName == "Sun")
		{
			SunLight.enabled = false;
		}
		else
		{
			SunLight.enabled = true;
		}
        
        

	}

}
