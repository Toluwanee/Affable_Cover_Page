using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 rot;
    //public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rot * Time.deltaTime);

       // transform.Translate(speed, 0, 0);


    }
}