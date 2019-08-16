using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerScript : MonoBehaviour {
    [Range(0.2f, 5f)] [SerializeField] float walkSpeed = 1f;
    [SerializeField] int damage = 10;
    float currentSpeed = 0;
    GameObject currentTarget;

    void Update() {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    void UpdateAnimationState() {
        if (!currentTarget) {
            GetComponent<Animator>().SetBool("isAttacking",false);
        }
    }
    public void SetMovementSpeed(float speed) {
        currentSpeed = speed * walkSpeed;
    }

    public void Attack(GameObject target) {
        GetComponent<Animator>().SetBool("isAttacking",true);
        currentTarget = target;
    }

    public void StrikeCurrentTarget() {
        if (!currentTarget) {
            return;
        }

        HealthScript health = currentTarget.GetComponent<HealthScript>();
        if (health) {
            health.DealDamage(damage);
        }
    }
}
