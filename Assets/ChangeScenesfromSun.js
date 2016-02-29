﻿var platform : RuntimePlatform = Application.platform;

function Update () {
    
    if(platform == RuntimePlatform.Android || platform == RuntimePlatform.IPhonePlayer)
    {
        if(Input.touchCount == 1) 
        {
            if(Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Application.LoadLevel("SunParticles");
            }
        }
    }
    else if(platform == RuntimePlatform.OSXEditor || platform == RuntimePlatform.WindowsEditor){

        if(Input.GetMouseButtonDown(0)) {
            Debug.Log("code is running");
            Application.LoadLevel("SunParticles");
            Debug.Log("buttn pressed");
        }
    }
}