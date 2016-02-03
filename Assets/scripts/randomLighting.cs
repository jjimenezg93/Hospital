using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class randomLighting : MonoBehaviour {

    public float randRate;
    public float lastChangeMinTime = 1;

    Light lightComp;

    float lastChange;

	void Start () {
        Random.seed = (int)Time.realtimeSinceStartup;
        lastChange = 0;
        
        foreach(Transform child in transform) {
            if (child.CompareTag("lampLight")) {
                lightComp = child.gameObject.GetComponent<Light>();
            }
        }
	}
	
	void Update () {
        lastChange += Time.deltaTime;
	    if (Random.value <= randRate && lastChange >= lastChangeMinTime) {
            lightComp.enabled = !lightComp.enabled;
            lastChange = 0;
        }
	}
}
