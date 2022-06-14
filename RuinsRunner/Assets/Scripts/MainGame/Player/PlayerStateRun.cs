using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateRun : StateBase
{
    PlayerController playerController;
    [SerializeField] float speed;   //左右移動速度

    public override void StateInitialize()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        speed = 5;

        playerController.animator.SetTrigger("StateRun");
    }

    public override StateBase StateUpdate(GameObject gameObject)
    {
        StateBase nextState = this;

        //横移動
        SideMove(gameObject);

        //仮
        if(Input.GetKeyDown(KeyCode.Space))
        {
            nextState = new PlayerStateDefeat();
        }

        return nextState;
    }

    public override void StateFinalize()
    {

    }

    //移動
    void SideMove(GameObject gameObject)
    {
        Vector3 moveVec = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveVec.x = speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveVec.x = -speed;
        }
        else
        {
            moveVec.x = 0;
        }

        gameObject.transform.position += moveVec * Time.deltaTime;
    }
}
