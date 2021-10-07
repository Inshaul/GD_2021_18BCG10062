using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPos : MonoBehaviour
{
    // Start is called before the first frame update
    public float lifeTime = 3f;

    // Update is called once per frame
    void Update()
    {
        if (lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
            transform.Translate(1f * Time.deltaTime, 0f, 0f);
        }
        if (lifeTime <= 0)
        {
            lifeTime += 3f;
        }
        
    }
}
