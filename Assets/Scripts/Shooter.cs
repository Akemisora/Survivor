using UnityEngine;

public class Shooter : MonoBehaviour {

    [SerializeField] private Transform source;
    [SerializeField] private Bullet prefab;


    public void Fire() {
        var b = Instantiate(prefab, source.position, source.rotation);
        b.Mover.Direction = source.rotation * Vector3.right;
    }

}
