using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public static float speed = -2f;
    public static float mass = 1;
    Rigidbody rid;
	// Start is called before the first frame update
    void Awake()
    {
        rid = GetComponent<Rigidbody>();
        mass = rid.mass;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        print("v2 = "+speed.ToString());
        rid.velocity = new Vector3(0,0,speed)*0.1f;
    }
}

