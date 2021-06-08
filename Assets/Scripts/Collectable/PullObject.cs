using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullObject : CollectableObject
{

    private float timer = 0f;


    private void Update()
    {
        ControlParent();
    }

    public void ControlParent()
    {
        if(transform.parent.GetComponent<ParentCubeOffset>().currentObjectState == ParentCubeOffset.ObjectState.pull)
        {
            timer += Time.deltaTime * 10;

            float x = Mathf.Cos(timer);
            float y = 0;
            float z = Mathf.Sin(timer);

            transform.position = new Vector3(transform.parent.transform.position.x + x, transform.parent.transform.position.y + y, transform.parent.transform.position.z + z);
        }
    }


}
