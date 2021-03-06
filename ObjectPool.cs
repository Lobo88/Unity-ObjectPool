using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool SharedInstance;
    public List<GameObject> pooleObjects;
    public GameObject objectToPool;
    public int amountToPool;
    public bool shouldExpand = true;
    private void Awake()
    {
        SharedInstance = this;
    }

    private void Start()
    {
        pooleObjects = new List<GameObject>();
        GameObject tmp;

        for(int i=0; i< amountToPool; i++)
        {
            tmp = Instantiate(objectToPool);
            tmp.SetActive(false);
            pooleObjects.Add(tmp);
        }
    }
    public GameObject GetPooledObject()
    {
        for(int i=0; i< amountToPool; i++)
        {
            if (!pooleObjects[i].activeInHierarchy)
            {
                return pooleObjects[i];
            }
        }
        if (shouldExpand)
        {
            GameObject obj = (GameObject)Instantiate(objectToPool);
            obj.SetActive(false);
            pooleObjects.Add(obj);
            return obj;
        }
        else
        {
            return null;
        }

    }
}
