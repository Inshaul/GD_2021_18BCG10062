using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float scoreAmount;
    public float L_t=.5f;



    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)scoreAmount + " Score";
        if (L_t > 0)
        {
            L_t -= Time.deltaTime;
        }
        if (L_t <= 0)
        {
            scoreAmount++;
            L_t = .5f;
        }
    }
}
