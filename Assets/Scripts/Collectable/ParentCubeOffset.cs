using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ParentCubeOffset : MonoBehaviour
{
    public enum ObjectState
    {
        stay,
        pull
    }

    public ObjectState currentObjectState;

    private GameObject ufo;

    private bool isCatch = false;

    private float ufoBottomPoint = 2f;

    private void Awake()
    {
        ufo = GameObject.Find("Ufo");
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "UfoField")
        {
            isCatch = true;
            currentObjectState = ObjectState.pull;
        }
      
    }

    private void LateUpdate()
    {
        if (isCatch) 
        {
            transform.position =new Vector3( ufo.transform.position.x, transform.position.y,ufo.transform.position.z);

            float offset = ufo.transform.position.y - transform.position.y;
            transform.DOMoveY(ufo.transform.position.y, offset/2f);
        }   

        if(transform.position.y >= ufo.transform.position.y-ufoBottomPoint)
        {
            Destroy(this.gameObject);
        }
    }
}
