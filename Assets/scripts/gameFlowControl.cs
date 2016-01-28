using UnityEngine;
using System.Collections;

public class gameFlowControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Escape)) {
            EndGame();
        }
	}

    void OnTriggerEnter(Collider other) {
        if (other.gameObject == GameObject.Find("player"))
            EndGame();
    }

    void EndGame() {
        Application.Quit();
    }
}
