using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sticktogetherScript : MonoBehaviour
{
    GameObject Player;
    Vector3 PlayerPos;
    Vector3 Distance;

    Rigidbody rb;

    Vector3 def;
    Vector3 _parent;
    Vector3 before;

    public GameObject[] objects;

    int count;
    int Number;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objects = GameObject.FindGameObjectsWithTag("After");
        count = objects.Length;
        Number = 76 - count;
        Debug.Log(Number);

        if(Number == 0)
        {
            FadeManager.Instance.LoadScene("GameClearScene", 1.0f);
        }

    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerPos = other.transform.position;

            Distance = transform.position - PlayerPos;
            Distance = Distance * 0.8f;
            transform.position = PlayerPos + Distance;
 


            this.transform.parent = other.transform;
            rb = GetComponent<Rigidbody>();
            Destroy(rb);

            this.tag = "After";
        }
    }
}
