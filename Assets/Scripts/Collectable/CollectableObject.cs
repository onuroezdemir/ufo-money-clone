using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObject : MonoBehaviour
{
   
    public virtual void DestroyObject()
    {
        Destroy(gameObject);
    }

}
