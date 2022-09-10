using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(5, 6, -12);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // add camara position to follow the vehicle
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
