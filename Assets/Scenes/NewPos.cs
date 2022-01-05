using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPos : MonoBehaviour {
    
    public float lifeTime = 3f;

    private void Update() {
        if (lifeTime > 0) {
            lifeTime -= Time.deltaTime;
            transform.Translate(1f * Time.deltaTime, 0f, 0f);
        }
        if (lifeTime <= 0) {
            lifeTime += 3f;
        }
        
    }
}
