using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    [SerializeField] private GameObject prefab;

    private void Update() {
        if (Random.value >= 0.1f) { return; }
        Spawn();
    }

    private void Spawn() {
        var player = WorldInfo.Instance.Player.transform;
        Instantiate(prefab, player.position + RandomOffset(), Quaternion.identity);

        Vector3 RandomOffset() {
            return new Vector3((2 * Random.Range(0, 2) - 1) * Random.Range(10f, 15f), (2 * Random.Range(0, 2) - 1) * Random.Range(10f, 15f));
        }
    }

}
