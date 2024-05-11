using UnityEngine;

public class WorldInfo : MonoBehaviour {

    [SerializeField] private Player player;
    
    public static WorldInfo Instance { get; private set; }
    public Player Player { get => player; set => player = value; }

    private void Awake() {
        Instance = this;
    }

}
