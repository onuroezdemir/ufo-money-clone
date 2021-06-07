using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class PlayerController : MonoBehaviour
{
    public enum PlayerState
    {
        stop = 0,
        pull = 1
    }

    public  PlayerState currentState { get; set; }

    public virtual void StateChange()
    {
        switch (currentState)
        {
            case PlayerState.stop:
                currentState = PlayerState.pull;
                break;
            case PlayerState.pull:
                currentState = PlayerState.stop;
                break;
        }

    }




}
