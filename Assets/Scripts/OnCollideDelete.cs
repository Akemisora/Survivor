using UnityEngine;

public class OnCollideDelete : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(gameObject);  
    }
}
