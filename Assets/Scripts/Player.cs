using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] private Health health;
    [SerializeField] private Mover mover;

    public Health Health { get => health; set => health = value; }
    public Mover Mover { get => mover; set => mover = value; }

    private void Update() {
        mover.Direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

}