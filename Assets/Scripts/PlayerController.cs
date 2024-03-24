using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        int a = 99;
        int b = 73;

        a = b + a;
        b = a - b;
        a = a - b;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0.01f, 0, 0));
        
    }
}
