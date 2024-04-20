using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolvingOrb : MonoBehaviour {

    [SerializeField] private GameObject orbPrefab;
    [SerializeField] private float radius;
    [SerializeField] private float rotationSpeed;

    private void Update() {
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }

    [ContextMenu(nameof(AddOrb))]
    private void AddOrb() {
        Instantiate(orbPrefab, transform);
        SpaceEqual();
    }

    [ContextMenu(nameof(RemoveOrb))]
    private void RemoveOrb() {
        var toRemove = transform.GetChild(transform.childCount - 1);
        toRemove.parent = null;
        Destroy(toRemove.gameObject);
        SpaceEqual();
    }

    private void SpaceEqual() {
        for (int i = 0; i < transform.childCount; i++) {
            Transform t = transform.GetChild(i);
            float angle = i * 360f / transform.childCount;
            float rad = angle * Mathf.Deg2Rad;
            t.localPosition = radius * new Vector3(Mathf.Cos(rad), Mathf.Sin(rad));
        }
    }

}
