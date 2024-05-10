using UnityEngine;

public class Lifetime : MonoBehaviour {

    [SerializeField] private float duration;

    public float Duration { get => duration; set => duration = value; }

    private void FixedUpdate() {
        duration -= Time.fixedDeltaTime;
        if (duration <= 0) {
            Destroy(gameObject);
        }
    }

}
