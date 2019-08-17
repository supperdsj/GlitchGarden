using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D otherCollider) {
        GameObject otherObject = otherCollider.gameObject;

        if (otherObject.GetComponent<GravestoneScript>()) {
            GetComponent<Animator>().SetTrigger("jumpTrigger");
        }else if (otherObject.GetComponent<DefenderScript>()) {
            GetComponent<AttackerScript>().Attack(otherObject);
        }
    }
}
