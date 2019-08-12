using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;

    public void DealDamage(float damage) {
        health -= damage;
        if (health <= 0) {
            Destroy(gameObject);
            TriggerDeathVFX();
        }
    }

    void TriggerDeathVFX() {
        if (!deathVFX) {
            return;
        }

        GameObject deathVFXObj = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(deathVFXObj,2f);
    }
}
