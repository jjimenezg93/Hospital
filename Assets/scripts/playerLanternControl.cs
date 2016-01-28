using UnityEngine;
using System.Collections;

public class playerLanternControl : MonoBehaviour {

    Light lightComp;

	void Start () {
        lightComp = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space)) {
            lightComp.enabled = !lightComp.enabled;
        }
	}
}
