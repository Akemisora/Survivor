using UnityEngine;

public class PlayerMover : Mover {

    private void Update() {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    protected override void FixedUpdate() {
        var position = rb.position;
        position += speed * Time.fixedDeltaTime * direction;
        position = WorldBorder.WorldBounds.ClosestPoint(position);
        rb.MovePosition(position);
    }
}