using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour {

    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private int count;

    private void Start() {
        var bounds = WorldBorder.WorldBounds;
        for (int i = 0; i < count; i++) {
            Instantiate(obstaclePrefab, RandomPosition(), RandomRotation());
        }

        Vector3 RandomPosition() {
            return new Vector3(Random.Range(bounds.min.x, bounds.max.x), Random.Range(bounds.min.y, bounds.max.y));
        }
        Quaternion RandomRotation() {
            return Quaternion.AngleAxis(Random.Range(0, 360f), Vector3.forward);
        }
    }

}
