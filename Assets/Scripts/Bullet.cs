using UnityEngine;

public class Bullet : MonoBehaviour {

    [SerializeField] private int damage;

    [SerializeField] private Mover mover;
    [SerializeField] private Lifetime lifetime;

    public int Damage { get => damage; set => damage = value; }
    public Mover Mover { get => mover; set => mover = value; }
    public Lifetime Lifetime { get => lifetime; set => lifetime = value; }
}
