var platform : RuntimePlatform = Application.platform;
 
 function Update(){

         if(Input.GetMouseButtonDown(0)) {
             Debug.Log("code is running");
             Application.LoadLevel("StartMenuScene");
             Debug.Log("buttn pressed");
         }
     
 }