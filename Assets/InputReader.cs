using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class InputReader : MonoBehaviour
{
    //List of input devices
    List<InputDevice> inputDevices = new List<InputDevice>();

    void InialiizeInputReader()
    {
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller, inputDevices);

        foreach (var inputDevice in inputDevices)
        {
            inputDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);

            //Log Trigger Use
            if (triggerValue > 0f)
            {
                Debug.Log(inputDevice.name + ": " + triggerValue);
            }
            // Debug.Log(inputDevice.name + " " + inputDevice.characteristics);
        }
    }


    void Start()
    {
        InialiizeInputReader();

    }

    // Update is called once per frame
    void Update()
    {

        if (inputDevices.Count < 2)
        {
            InialiizeInputReader();
        }

    }
}
