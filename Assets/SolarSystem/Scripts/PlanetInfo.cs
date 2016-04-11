using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine.UI;

public class PlanetInfo : MonoBehaviour {

    private List<string> infoList { get; set; }
    public Text contentText;
    public Text planetNameText;
    private RectTransform rectTransform;
    public float dpi = 5;
    private PlanetSwitch planetSwitchScript;


	// Use this for initialization
	void Start () {
        rectTransform = contentText.GetComponent<RectTransform>();
        planetSwitchScript = gameObject.AddComponent<PlanetSwitch>();
        planetSwitchScript.SunLight = GameObject.Find("SunLight").GetComponent<Light>();
    }

    public void LoadTextToScrollBar(string name)
    {
        StreamReader sReader = null;
        string line;

        string path = Path.Combine(Application.dataPath, string.Format("SolarSystem/PlanetInfo/{0}.txt", name));

        // clear content
        contentText.text = string.Empty;
        
        if (File.Exists(path))
        {
            // Find if we are in webplayer mode

            if (Application.isWebPlayer)
            {
                sReader = new StreamReader(new WWW(path).url, Encoding.Default);
            }
            else
            {
                sReader = new StreamReader(path, Encoding.Default);

            }

            using (sReader)
            {
              
                int lines = 0;
                while ((line = sReader.ReadLine()) != null)
                {
                    line = line.Replace("NEWLINE", "\n");
                    line = line.Replace("TAB", "\t");
                    contentText.text += line;
                    lines++;
                }
                
                // We have to increase height of the content - 1 line  = 20 dpi
                rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, lines * dpi);
                
            }
            
        }
        else
        {
            // No info for planet - please add PlanetName.txt to SolarSystem/PlanetInfo
            contentText.text = string.Format("Please add {0}.txt to SolarSystem/PlanetInfo", name);
        }

        planetNameText.text = name;
        planetSwitchScript.AssignPlanetCameraCoordinates(name);
    }
}
