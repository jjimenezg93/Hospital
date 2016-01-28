using UnityEngine;
using System.Collections;

public class randomScare : MonoBehaviour {

    public float rate;

    AudioSource audioComp;
    GameObject player;

    void Start () {
        audioComp = GetComponent<AudioSource>();
        player = GameObject.Find("player");
        Random.seed = (int)Time.realtimeSinceStartup;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) {
        if (other.gameObject == player && !audioComp.isPlaying && Random.value <= rate ) {
            audioComp.Play();
        }
    }
}
