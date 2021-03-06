using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMG1Idle : StateBase
{
    StateBase nextState;
    PlayerController playerController_;

    public override void StateInitialize()
    {
        playerController_ = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        playerController_.animator_.SetTrigger("StateMG1Idle");
        nextState = this;
        Debug.Log(this.ToString() + "に入った");
    }

    public override StateBase StateUpdate(GameObject gameObject)
    {
        //状態遷移
        //優先度低-------------------------------------------------------------------

        //走り状態
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            nextState = new PlayerStateMG1Run();

        //ジャンプ状態
        if (Input.GetKeyDown(KeyCode.W))
            nextState = new PlayerStateMG1Jump();

        //落下状態
        if (!playerController_.OnGround())
            nextState = new PlayerStateMG1Fall();

        //優先度高-------------------------------------------------------------------
        return nextState;
    }
    public override void StateFinalize()
    {

    }

}