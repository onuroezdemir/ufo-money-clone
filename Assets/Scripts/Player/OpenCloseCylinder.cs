using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OpenCloseCylinder : PlayerController
{
    private void Update()
    {
        CheckTouch();
        ScaleChange();
    }

    private void ScaleChange()
    {
        switch (base.currentState)
        {
            case PlayerState.stop:
                CylinderScaleDown();
                break;
            case PlayerState.pull:
                CylinderScaleUp();
                break;
        }
    }

    public void CheckTouch()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonUp(0))
        {
            base.StateChange();
        }
    }

    private void CylinderScaleUp()
    {
        this.transform.DOScaleY(0.05f, 1);
    }

    private void CylinderScaleDown()
    {
        this.transform.DOScaleY(0, 1);
    }
}
