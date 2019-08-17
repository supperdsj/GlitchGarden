using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravestoneScript : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D otherCollider) {
        AttackerScript attacker = otherCollider.GetComponent<AttackerScript>();
        if (attacker) {
            // attacker.Attack(gameObject);
        }
    }
}
