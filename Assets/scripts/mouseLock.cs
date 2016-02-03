using UnityEngine;
using System.Collections;

public class mouseLock : MonoBehaviour {

	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
