using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
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

        if (Input.GetKey(KeyCode.W))
        {
            v.z = moveSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            v.z = -moveSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            v.x = moveSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            v.x = -moveSpeed;
        }
        else
        {
            v.x = 0;
            v.z = 0;
        }
        rb.velocity = v;

        if(posi.y < -30)
        {
            FadeManager.Instance.LoadScene("GameOverScene", 1.0f);
        }
    }
}
