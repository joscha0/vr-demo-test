using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackForth : MonoBehaviour
{
    public float distanceToCover;
    public float speed;

    private Vector3 startingPosition;
    bool canMove = true;

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            canMove = false;
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Player") {
            canMove = true;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove){
            Vector3 v = startingPosition;
            v.z = distanceToCover * Mathf.Sin(Time.time * speed);
            transform.position = v;
        }
    }
}
