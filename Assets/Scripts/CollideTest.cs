using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideTest : MonoBehaviour, IMyUpdatable {

    [SerializeField] private Collider2D[] collisionResult;
    [SerializeField] private int resultCount;
    [SerializeField] private Collider2D col;

    private void OnEnable() {
        Updater.Instance.Register(this, 0);
    }

    private void OnDisable() {
        
    }


    [ContextMenu(nameof(CheckOverlap))]
    private void CheckOverlap() {
        resultCount = col.OverlapCollider(new ContactFilter2D().NoFilter(), collisionResult);
        for (int i = 0; i < resultCount; i++) {
            Debug.Log(collisionResult[i]);
        }
    }

    public void OnUpdate() => throw new System.NotImplementedException();
}
