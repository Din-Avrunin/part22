using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] int speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = transform.position;
        float progress = speed * Time.deltaTime;
        if (Input.GetKey("up"))
        {
            transform.position = new Vector3(vec.x, vec.y + progress, vec.z);
        }
        else if (Input.GetKey("left"))
        {
            transform.position = new Vector3(vec.x - progress, vec.y, vec.z);
        }
        else if (Input.GetKey("right"))
        {
            transform.position = new Vector3(vec.x + progress, vec.y, vec.z);
        }
        else if (Input.GetKey("down"))
        {
            transform.position = new Vector3(vec.x, vec.y - progress, vec.z);
        }
    }
}
