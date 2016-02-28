using UnityEngine;
using System.Collections;
using System;

public class menuMain : MonoBehaviour
{

    // ....I don't really know what I'm doing here
    public GameObject sun;
    public GameObject earth;

    // Use this for initialization
    void Start()
    {
        Cardboard.Create();

        sun = GameObject.FindGameObjectWithTag("SUN");
        earth = GameObject.FindGameObjectWithTag("EARTH");
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
        Application.LoadLevel("sun");

    }

    //does the same 
    public void earthPress()
    {


        Debug.Log("in earth \n");
        Application.LoadLevel("earth");

    }
}
