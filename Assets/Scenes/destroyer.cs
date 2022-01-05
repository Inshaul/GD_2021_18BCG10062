using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    float lifeTime=5f;
    float spawnTime = 2f;
    bool newGroundInstanciated;
    readonly List<Vector3> pos = new List<Vector3>() { new Vector3(9, 0, 0), new Vector3(-9, 0, 0), new Vector3(0, 0, 9), new Vector3(0, 0, -9) };

    private void Awake()
    {
        newGroundInstanciated = false;
    }
    private void Update() {
        if (lifeTime > 0) {
            lifeTime -= 1*Time.deltaTime;
            GroundTimer(lifeTime);
            if (!newGroundInstanciated && lifeTime < spawnTime)
            {
                GenerateGround();
            }
            if (lifeTime <= 0) {
                Destruction();
                lifeTime = 5f;
            }
        }

    }
    
    private void OnCollisionEnter(Collision coll) {
        if (coll.gameObject.name == "destroyer") {
            Destruction();
        }
    }
    private void GenerateGround()
    {
        newGroundInstanciated = true;
        int index = Random.Range(0, pos.Capacity);
        Vector3 newpos = new Vector3(gameObject.transform.position.x + pos[index].x, 0, gameObject.transform.position.z + pos[index].z);
        Instantiate(gameObject, newpos, Quaternion.identity);
    }
    private void Destruction() {
        Destroy(this.gameObject);
    }
    private void GroundTimer(float lifeTime)
    {
        gameObject.transform.Find("Canvas").Find("Timer").GetComponent<TMP_Text>().text = lifeTime.ToString().Substring(0, 4);
    }
}
