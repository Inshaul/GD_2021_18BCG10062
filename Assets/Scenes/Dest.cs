using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dest : MonoBehaviour
{
    // Start is called before the first frame update
   
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "destroyer")
        {
            Destruction();
        }
    }
    void Destruction()
    {
        Destroy(this.gameObject);
        FindObjectOfType<GameManager>().EndGame();
    }
}
