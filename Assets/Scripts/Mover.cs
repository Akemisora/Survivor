using UnityEngine;

public class Mover : MonoBehaviour {

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private Vector2 direction;

    public float Speed { get => speed; set => speed = value; }
    public Vector2 Direction { get => direction; set => direction = value; }

    protected virtual void FixedUpdate() {
        var position = rb.position;
        position += speed * Time.fixedDeltaTime * direction;
        rb.MovePosition(position);
    }

}
