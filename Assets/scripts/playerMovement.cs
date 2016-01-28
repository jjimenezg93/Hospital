using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

    public float moveSpeed;

    AudioSource audioComp;
    CharacterController controller;

    Vector3 moveDirection;

    void Start() {
        controller = GetComponent<CharacterController>();
        audioComp = GetComponent<AudioSource>();
        audioComp.enabled = true;
    }

    void Update () {
        if (Input.GetKey(KeyCode.A)) {
            moveDirection = -transform.right;
            moveDirection.y = 0;
            controller.Move((moveDirection * moveSpeed) * Time.deltaTime);
            if (!audioComp.isPlaying) {
                audioComp.Play(0);
            }
        }
        if (Input.GetKey(KeyCode.D)) {
            moveDirection = transform.right;
            moveDirection.y = 0;
            controller.Move((moveDirection * moveSpeed) * Time.deltaTime);
            if (!audioComp.isPlaying) {
                audioComp.Play(0);
            }
        }
        if (Input.GetKey(KeyCode.W)) {
            moveDirection = transform.forward;
            moveDirection.y = 0;
            controller.Move((moveDirection * moveSpeed) * Time.deltaTime);
            if (!audioComp.isPlaying) {
                audioComp.Play(0);
            }
        }
        if (Input.GetKey(KeyCode.S)) {
            moveDirection = transform.forward;
            moveDirection.y = 0;
            controller.Move(-(moveDirection * moveSpeed) * Time.deltaTime);
            if (!audioComp.isPlaying) {
                audioComp.Play(0);
            }
        }
    }

    void OnCollisionEnter(Collision c) {
        
    }

    void OnCollisionExit(Collision c) {
        
    }
}
