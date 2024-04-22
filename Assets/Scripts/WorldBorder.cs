using UnityEngine;

public class WorldBorder : MonoBehaviour {

    [SerializeField] private Bounds worldBounds;

    private static WorldBorder Instance;
    public static Bounds WorldBounds => Instance.worldBounds;

    private void Awake() {
        Instance = this;
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(worldBounds.center, worldBounds.size);
    }

}
