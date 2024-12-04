using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class LevelUpScript : MonoBehaviour
{

    int count;
    int Number;

    public GameObject[] objects;
    private float timer;
    public float finishedtime = 5.0f;
    public GameObject LevelUp;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        LevelUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        objects = GameObject.FindGameObjectsWithTag("After");
        count = objects.Length;
        Number = 75 - count;

        if(Number <= 50 )
        {
            timer += Time.deltaTime;
            LevelUp.SetActive(true);

            if (timer > finishedtime)
            {
                timer = 0;
                LevelUp.SetActive(false);
            }
        }
    }
}
