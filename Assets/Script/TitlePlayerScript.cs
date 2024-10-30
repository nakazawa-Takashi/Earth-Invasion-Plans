using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitlePlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    float moveSpeed = 10.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = rb.velocity;
        Vector3 posi = this.transform.position;

        
            v.x = moveSpeed;
        transform.position = new Vector3(transform.position.x + moveSpeed, posi.x, posi.y); 

        if (posi.x < -50)
        {

        }
    }
}