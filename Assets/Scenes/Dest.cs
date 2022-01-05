using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dest : MonoBehaviour {
     
    private void OnCollisionEnter(Collision coll) {
        if (coll.gameObject.name == "destroyer") {
            Destruction();
        }
    }
    private void Destruction() {
        Destroy(this.gameObject);
        FindObjectOfType<GameManager>().EndGame();
    }
}
