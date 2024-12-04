using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    public GameObject[] smoll;

    int count;
    int Number;

    // Start is called before the first frame update
    void Start()
    {
        smoll = GameObject.FindGameObjectsWithTag("smoll");
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision other)
    {
        objects = GameObject.FindGameObjectsWithTag("After");
        count = objects.Length;
        Number = 75 - count;

        if (other.gameObject.tag == "Player")
        {
            if (Number > 0)
                if (gameObject.tag == "smoll")
                {
                    PlayerPos = other.transform.position;

                    Distance = transform.position - PlayerPos;
                    Distance = Distance * 0.5f;
                    transform.position = PlayerPos + Distance;


                    this.transform.parent = other.transform;
                    rb = GetComponent<Rigidbody>();
                    Destroy(rb);

                    this.tag = "After";

                }
                else {
                    if (Number <= 50)
                    {
                        if (gameObject.tag == "medium")
                        {
                            PlayerPos = other.transform.position;

                            Distance = transform.position - PlayerPos;
                            Distance = Distance * 0.5f;
                            transform.position = PlayerPos + Distance;


                            this.transform.parent = other.transform;
                            rb = GetComponent<Rigidbody>();
                            Destroy(rb);

                            this.tag = "After";
                        }
                    }

                }
                else
                {
                    if (Number <= 30)
                    {
                        if (gameObject.tag == "big")
                        {
                            PlayerPos = other.transform.position;

                            Distance = transform.position - PlayerPos;
                            Distance = Distance * 0.5f;
                            transform.position = PlayerPos + Distance;


                            this.transform.parent = other.transform;
                            rb = GetComponent<Rigidbody>();
                            Destroy(rb);

                            this.tag = "After";
                        }
                    }

                }
        }
    }
}
