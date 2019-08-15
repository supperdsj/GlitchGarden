using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour {
    [SerializeField] GameObject projectile, gun;
    AttackerSpawnerScript myLaneSpawner;
    Animator animator;

    public void Fire() {
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);
    }

    void SetLaneSpawner() {
        AttackerSpawnerScript[] spawners = FindObjectsOfType<AttackerSpawnerScript>();
        foreach (AttackerSpawnerScript spawner in spawners) {
            bool isCloseEnouth = Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon;

            if (isCloseEnouth) {
                myLaneSpawner = spawner;
            }
        }
    }

    bool IsAttackerInLane() {
        return myLaneSpawner.transform.childCount > 0;
    }

    void Start() {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
    }

    void Update() {
        if (IsAttackerInLane()) {
            animator.SetBool("isAttacking",true);
            // Debug.Log("shoot pew pew");
        }
        else {
            animator.SetBool("isAttacking",false);
            // Debug.Log("sit and wait");
        }
    }
}
