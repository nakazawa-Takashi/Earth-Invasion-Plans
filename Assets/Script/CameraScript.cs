using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;

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
        position.y = playerPosition.y+4;
        position.z = playerPosition.z-20;
        rotation.x = playerRotation.x+7;
        transform.position = position;

        
    }
}
