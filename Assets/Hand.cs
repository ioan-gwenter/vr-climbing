using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Hand : MonoBehaviour
{

    public GameObject handPrefab;

    public InputDeviceCharacteristics inputDeviceCharacteristics;

    private InputDevice _targetDevice;
    private Animator _handAnimator;


    private void InitializeHand()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(inputDeviceCharacteristics, devices);

        if (devices.Count > 0)
        {
            _targetDevice = devices[0];

            GameObject spawnedHand = Instantiate(handPrefab, transform);
            _handAnimator = spawnedHand.GetComponent<Animator>();
        }
    }

    private void UpdateHand()
    {
        if (_targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            _handAnimator.SetFloat("Trigger", triggerValue);
        }
        else
        {
            _handAnimator.SetFloat("Trigger", 0);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        InitializeHand();

    }

    // Update is called once per frame
    void Update()
    {
        if (!_targetDevice.isValid)
        {
            InitializeHand();
        }
        else
        {
            UpdateHand();
        }

    }
}
