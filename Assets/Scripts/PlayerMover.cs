using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] private Mover mover;


    private void Update() {
        mover.Direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

}