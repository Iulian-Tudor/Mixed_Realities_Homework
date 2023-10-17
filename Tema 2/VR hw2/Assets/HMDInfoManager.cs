using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("no headset");
        }

        else if (XRSettings.isDeviceActive &&
                 (XRSettings.loadedDeviceName == "Mock HMD" || XRSettings.loadedDeviceName == "MockHMD Display"))
        {
            Debug.Log("using mock hmd");
        }
        else
        {
            Debug.Log("headset detected");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
