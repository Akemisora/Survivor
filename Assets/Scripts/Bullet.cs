using UnityEngine;

public class Bullet : MonoBehaviour {

    [SerializeField] private int damage;
    [SerializeField] private int pierce;

    [SerializeField] private LayerMask targetMask;
    [SerializeField] private LayerMask groundMask;

    [SerializeField] private Mover mover;
    [SerializeField] private Lifetime lifetime;

    public int Damage { get => damage; set => damage = value; }
    public int Pierce { get => pierce; set => pierce = value; }
    public LayerMask TargetMask { get => targetMask; set => targetMask = value; }
    public LayerMask GroundMask { get => groundMask; set => groundMask = value; }
    public Mover Mover { get => mover; set => mover = value; }
    public Lifetime Lifetime { get => lifetime; set => lifetime = value; }

    private void OnTriggerEnter2D(Collider2D other) {

        var otherMask = other.GetLayerMask();

        if ((otherMask & groundMask) != 0) {
            Destroy(gameObject);
            return;
        }
        if ((otherMask & targetMask) == 0) { return; }

        if (!other.TryGetComponent<IDamagable>(out var d)) { return; }
        d.TakeDamage(damage);
        pierce--;
        if (pierce <= 0) {
            Destroy(gameObject);
        }
    }

}


public static class ColliderExt {

    public static LayerMask GetLayerMask(this Collider2D col) {
        return 1 << col.gameObject.layer;
    }
}