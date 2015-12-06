var platform : RuntimePlatform = Application.platform;
 
 function Update(){

     if(platform == RuntimePlatform.Android || platform == RuntimePlatform.IPhonePlayer){
         if(Input.touchCount > 0) {
             if(Input.GetTouch(0).phase == TouchPhase.Began){
                 Application.LoadLevel("earthday");
             }
         }
     }else if(platform == RuntimePlatform.OSXEditor){

         if(Input.GetMouseButtonDown(0)) {
               	Debug.Log("code is running");
             Application.LoadLevel("earthday");
             Debug.Log("buttn pressed");
         }
     }
 }