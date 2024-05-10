using UnityEngine;

public class ColliderCaster : MonoBehaviour {

    private static readonly Collider2D[] results = new Collider2D[8];
    private static int resultCount;

    [SerializeField] private Collider2D coll;
    [SerializeField] private ContactFilter2D filter = new ContactFilter2D().NoFilter();

    public void Cast() {
        resultCount = coll.OverlapCollider(filter, results);
    }
}
