using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerScript : MonoBehaviour {
    [Range(0.2f, 5f)] [SerializeField] float walkSpeed = 1f;
    float currentSpeed = 0;

    void Update() {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed) {
        currentSpeed = speed * walkSpeed;
    }
}
