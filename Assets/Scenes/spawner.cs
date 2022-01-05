using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public Transform spawnPos;
    public GameObject spawnee;
    public float lifeTime = 5f;


    private void Update() {
        if (lifeTime > 0) {
            lifeTime -= Time.deltaTime;
            if (lifeTime <= 0) {
                Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
                lifeTime = 5f;
            }
        }
    }
}
