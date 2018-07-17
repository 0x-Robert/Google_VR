using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {
    public WebCamTexture webcamtexture;
    private GUITexture BackgroundTexture;
	
	void Start ()
    {
        Debug.Log("카메라셋팅");
        GetComponent<GUITexture>().pixelInset = new Rect(0, 0, Screen.width, Screen.height);

        webcamtexture = new WebCamTexture();
        webcamtexture.requestedWidth = 1920;
        webcamtexture.requestedHeight = 1080;
        webcamtexture.Play();

        GetComponent<GUITexture>().texture = webcamtexture;

    }


}
