using System.Collections;
using UnityEngine;

public class AttackerSpawnerScript : MonoBehaviour {
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] AttackerScript[] attackerPrefabArray;
    bool spawn = true;

    IEnumerator Start() {
        while (spawn) {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    public void StopSpawning() {
        spawn = false;
    }
    void Spawn(AttackerScript myAttacker) {
        AttackerScript newAttacker = Instantiate(myAttacker, transform.position, transform.rotation);
        // newAttacker.transform.parent = transform;
        newAttacker.transform.SetParent(transform);
    }
    void SpawnAttacker() {
        var attackerIndex = Random.Range(0, attackerPrefabArray.Length);
        Spawn(attackerPrefabArray[attackerIndex]);
    }
}
