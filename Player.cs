using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public GameObject turret;
    private void Awake()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            for (int i = 0; i < 5; i++)
            {
                GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();

                if (bullet != null)
                {
                    bullet.transform.position = new Vector3(turret.transform.position.x, turret.transform.position.y, turret.transform.position.z - 1);
                    // bullet.transform.rotation = turret.transform.rotation;
                    bullet.SetActive(true);
                    StartCoroutine(LateCall(bullet));
                }
            }
        }
    }
    IEnumerator LateCall(GameObject bullet)
    {
        yield return new WaitForSeconds(3f);
        bullet.gameObject.SetActive(false);
        Debug.Log("usun");
    }
}


