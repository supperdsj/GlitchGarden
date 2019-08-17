using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageColliderScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D otherCollider) {
        if (otherCollider.GetComponent<AttackerScript>()) {
            FindObjectOfType<LivesDisplayScript>().TakeLife();
        }
    }
}
