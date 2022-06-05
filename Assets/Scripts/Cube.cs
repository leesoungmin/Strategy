using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, Weapon
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Shoot(GameObject obj)
    {
        GameObject bullet = Instantiate(obj, transform.position, Quaternion.identity);
    }
}
