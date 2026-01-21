using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y > 0.5)
        {
            transform.position -= Vector3.up * 0.0625f;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * 0.125f;
        }

            if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * 0.125f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * 0.125f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * 0.125f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * 0.125f;
        }
    }
}
