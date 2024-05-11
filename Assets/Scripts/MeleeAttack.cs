using UnityEngine;

public class MeleeAttack : MonoBehaviour {

    private static readonly Collider2D[] results = new Collider2D[8];
    private static int resultCount;

    [SerializeField] private Collider2D coll;
    [SerializeField] private ContactFilter2D filter = new ContactFilter2D().NoFilter();
    [SerializeField] private int damage;

    private void Start() {
        int resultCount = coll.OverlapCollider(filter, results);

        for (int i = 0; i < resultCount; i++) {
            var other = results[i];
            if (other.gameObject == WorldInfo.Instance.Player.gameObject) { Debug.Log("HIT PLAYER"); }
            if (!other.TryGetComponent<IDamagable>(out var d)) { return; }
            d.TakeDamage(damage);
        }

        Destroy(gameObject, 0.05f);
    }
}
