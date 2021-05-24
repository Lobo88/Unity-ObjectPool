using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    void Update()
    {
       
        if (this.gameObject.activeInHierarchy == true )
        {
           this.transform.Translate(Random.Range(-10, 10) * Time.deltaTime, 0, -2 * Time.deltaTime);
        }
        
        
    }
}
