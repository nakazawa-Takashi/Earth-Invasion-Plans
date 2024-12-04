using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;

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
        var playerPosition = player.transform.position;
        var position = transform.position;
        var playerRotation = player.transform.rotation;
        var rotation = transform.rotation;

        objects = GameObject.FindGameObjectsWithTag("After");
        count = objects.Length;
        Number = 75 - count;

        if (Number > 50)
        {
            position.x = playerPosition.x;
            position.y = playerPosition.y + 6;
            position.z = playerPosition.z - 15;
            rotation.x = playerRotation.x + 15;

        }

        if(Number <= 50)
        {
            position.x = playerPosition.x;
            position.y = playerPosition.y + 10;
            position.z = playerPosition.z - 30;
            rotation.x = playerRotation.x + 35;

        }

        if (Number <= 30)
        {
            position.x = playerPosition.x;
            position.y = playerPosition.y + 15;
            position.z = playerPosition.z - 45;
            rotation.x = playerRotation.x + 60;

        }



        transform.position = position;

        
    }
}
