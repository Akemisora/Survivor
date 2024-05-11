using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] private Health health;
    [SerializeField] private Mover mover;
    [SerializeField] private Shooter shooter;
    [SerializeField] private Melee melee;

    public Health Health { get => health; set => health = value; }
    public Mover Mover { get => mover; set => mover = value; }

    private void Update() {
        mover.Direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        if (Input.GetMouseButtonDown(0)) {
            shooter.Fire();
        }
        if (Input.GetMouseButtonDown(1)) {
            melee.Fire();
        }
    }

}