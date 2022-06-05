using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.y < 10f)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
