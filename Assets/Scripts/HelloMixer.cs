using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloMixer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MixerInteractive.GoInteractive();
    }
	
	// Update is called once per frame
	void Update () {
		if (MixerInteractive.GetButton("Up"))
        {
            Debug.Log("Player pressed up");
        }
	}
}
