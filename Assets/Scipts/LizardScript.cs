using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizardScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D otherCollider) {
        GameObject otherObject = otherCollider.gameObject;
        if (otherObject.GetComponent<DefenderScript>()) {
            GetComponent<AttackerScript>().Attack(otherObject);
        }
    }
}
