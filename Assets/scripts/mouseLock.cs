using UnityEngine;
using System.Collections;

public class mouseLock : MonoBehaviour {

	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}

    void Update() {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
