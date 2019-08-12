using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {
    [SerializeField] float speed = 10f;
    [SerializeField] float damage = 50f;
    void Update()
    {
        transform.Translate(Vector2.right*speed*Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D otherCollider) {
        var health = otherCollider.GetComponent<HealthScript>();
        var attacker = otherCollider.GetComponent<AttackerScript>();
        if(attacker && health){
            health.DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
