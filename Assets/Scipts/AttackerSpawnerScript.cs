using System.Collections;
using UnityEngine;

public class AttackerSpawnerScript : MonoBehaviour {
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] AttackerScript attackerPrefab;
    bool spawn = true;

    IEnumerator Start() {
        while (spawn) {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    void SpawnAttacker() {
        AttackerScript newAttacker = Instantiate(attackerPrefab, transform.position, transform.rotation);
        // newAttacker.transform.parent = transform;
        newAttacker.transform.SetParent(transform);
    }
}
