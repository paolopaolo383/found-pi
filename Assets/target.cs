using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class target : MonoBehaviour
{
    public static float speed = 0;
    public static float mass = 1;
    Rigidbody rid;

    public Text sumtext;
    public int sum = 0;
	// Start is called before the first frame update
	private void Awake()
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
        print("v1 = " + speed.ToString());
        rid.velocity = new Vector3(0, 0, speed)*0.1f;
        sumtext.text = sum.ToString();
    }
    public void OnTriggerEnter(Collider other)
	{
        sum++;
        if(other.gameObject.tag == "box")
		{
            float v1 = speed;
            float v2 = Control.speed;
            float m1 = mass;
            float m2 = Control.mass;

            speed = ((m1 - m2) / (m1 + m2) * v1) + ((2 * m2) / (m1 + m2) * v2);

            Control.speed = ((2 * m1) / (m1 + m2) * v1) - ((m1 - m2) / (m1 + m2) * v2);


        }
        else if (other.gameObject.tag == "wall")
		{
            speed = speed * -1;
		}


    }
}
