using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Mover : MonoBehaviour {

    protected Rigidbody2D rb;
    [SerializeField] protected float speed;
    [SerializeField] protected Vector2 direction;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    protected virtual void FixedUpdate() {
        var position = rb.position;
        position += speed * Time.fixedDeltaTime * direction;
        rb.MovePosition(position);
    }

}
