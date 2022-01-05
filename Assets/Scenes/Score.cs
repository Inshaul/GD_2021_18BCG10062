using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    float scoreAmount=1f;
    public float L_t=3f;
    //public

    private void Start() {
       // scoreAmount = 1f;

    }

    private void Update()
    {

        scoreText.text = (int)scoreAmount + " Score";
        if (L_t > 0) {
            L_t -= 1*Time.deltaTime;
        }
        if (L_t <= 0) {
            scoreAmount++;
            L_t = 3f;
        }
    }
}
