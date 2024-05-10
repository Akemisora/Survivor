using UnityEngine;

public class PointerIndicator : MonoBehaviour {

    [SerializeField] private Pointer pointer;
    [SerializeField] private Transform indicator;

    private void Update() {
        indicator.rotation = Quaternion.FromToRotation(Vector3.right, pointer.Direction);
    }

}
