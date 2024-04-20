using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Updater : MonoBehaviour {

    public static Updater Instance;

    List<IMyUpdatable>[] lists;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        foreach (var list in lists) {
            foreach (var u in list) { u.OnUpdate(); }
        }
    }

    public void Register(IMyUpdatable u, int priority) {
        lists[priority].Add(u);
    }
}

public interface IMyUpdatable {

    void OnUpdate();
}
