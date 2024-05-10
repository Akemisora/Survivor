using UnityEngine;

public class Pointer : MonoBehaviour {

    private Vector2 direction;

    public Vector2 Direction => direction;

    private void Update() {
        direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;
    }



}
