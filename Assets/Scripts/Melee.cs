using UnityEngine;

public class Melee : MonoBehaviour {

    [SerializeField] private Transform source;
    [SerializeField] private MeleeAttack prefab;

    public void Fire() {
        Instantiate(prefab, source.position, source.rotation);
    }

}