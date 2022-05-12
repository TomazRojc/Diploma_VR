using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour
{

    public Camera cam1;
    public Material cameraMat1;
    public Camera cam2;
    public Material cameraMat2;


    // Start is called before the first frame update
    void Start()
    {
        if (cam1.targetTexture != null) {
            cam1.targetTexture.Release();
        }
        cam1.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMat1.mainTexture = cam1.targetTexture;

        if (cam2.targetTexture != null) {
            cam2.targetTexture.Release();
        }
        cam2.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMat2.mainTexture = cam2.targetTexture;
    }
}
