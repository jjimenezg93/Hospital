using UnityEngine;
using System.Collections;

public class pickObject : MonoBehaviour {

    Ray ray;
    RaycastHit hit;

    GameObject player;

	void Start () {
        player = GameObject.Find("player");
	}
	
	void Update () {
	    if(Input.GetMouseButtonDown(0)) {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit)) {
                GameObject obj = hit.collider.gameObject;
                if (obj.CompareTag("pickable")) {
                    player.GetComponent<inventory>().AddObject(obj);
                    obj.SetActive(false);
                }
            }
        }
	}
}
