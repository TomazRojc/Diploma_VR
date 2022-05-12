using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugUI : MonoBehaviour
{
    public Text XROriginText;
    public Text CamOffsetText;
    public Text MainCamText;

    public Transform XROrigin;
    public Transform CamOffset;
    public Transform MainCam;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        XROriginText.text = XROrigin.position.ToString();
        CamOffsetText.text = CamOffset.position.ToString();
        MainCamText.text = MainCam.position.ToString();
    }
}
