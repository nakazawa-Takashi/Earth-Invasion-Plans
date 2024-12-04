using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniCameraScript : MonoBehaviour
{

    public GameObject player;

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
        position.x = playerPosition.x;
        position.y = playerPosition.y + 30;
        position.z = playerPosition.z;
        rotation.x = playerRotation.x + 90;
        transform.position = position;
    }
}
