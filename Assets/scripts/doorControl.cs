using UnityEngine;
using System.Collections;

public class doorControl : MonoBehaviour {

    public GameObject neededObject;

    Animator animator;
    AudioSource audioComp;

    GameObject player;

	void Start () {
        player = GameObject.Find("player");
        audioComp = GetComponent<AudioSource>();
        animator = GetComponentInChildren<Animator>();
        animator.SetBool("isOpen", false);
        audioComp.enabled = true;
	}
	
	void Update () {}

    void OnTriggerEnter(Collider other) {
        if (other.gameObject == player && (neededObject == null || player.GetComponent<inventory>().IsObject(neededObject))) {
            animator.SetBool("isOpen", true);
            audioComp.Play();
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject == player && (neededObject == null || player.GetComponent<inventory>().IsObject(neededObject))) {
            animator.SetBool("isOpen", false);
            audioComp.Play();
        }
    }
}
