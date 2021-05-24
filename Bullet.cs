using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Update()
    {
        if (this.gameObject.activeInHierarchy == true)
        {
            this.transform.Translate(0, 0, -2 * Time.deltaTime);
        }
    }
}
