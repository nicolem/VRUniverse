#pragma strict

static var exists;
static var fadein = true;
static var fadeout = false;
var rend: Renderer;
var fadeSpeed = 1;
var duration : float = 1;

public function FadeIn(){
    fadein = true;
    fadeout = false;
    Debug.Log("Fading In");
}

public function FadeOut(){
    fadein = false;
    fadeout = true;
    Debug.Log("Fading Out");
}

function Start () {

    if (exists){
        Destroy(gameObject);
        Debug.Log("extra fader destroyed");
    }

    else {
//      exists = true;
//	DontDestroyOnLoad(transform.gameObject);
    }

//    Debug.Log("Starting Up");
    rend = GetComponent.<Renderer>();
    rend.material.color = Color.black;
    fadein = true;
}

function Update () {
    if (fadein){
	rend.material.color = Color.Lerp(rend.material.color, new Color(0,0,0,0), fadeSpeed * Time.deltaTime);
	Debug.Log(rend.material.color.a);
	if(rend.material.color.a <= 0.01){
            fadein = false;
        }
    }

    if (fadeout){
	rend.material.color = Color.Lerp(rend.material.color, Color.black, fadeSpeed * Time.deltaTime);
        if(rend.material.color.a >= 0.01){
            fadeout = false;
        }
    }
}

