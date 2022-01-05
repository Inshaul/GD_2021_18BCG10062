
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed;
    private void Start() {
        speed = 10f;
    }

    
    private void Update() { 
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(horizontal, 0, vertical);
    }
}
