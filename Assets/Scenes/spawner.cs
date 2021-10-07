using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;
    public float lifeTime = 3f;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
            if (lifeTime <= 0)
            {
                Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
                lifeTime = 3f;
            }
        }
    }
}
