using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    [SerializeField] private Mover mover;

    private void FixedUpdate() {
        mover.Direction = ((Vector2)(WorldInfo.Instance.Player.transform.position - transform.position)).normalized;
    }

}
