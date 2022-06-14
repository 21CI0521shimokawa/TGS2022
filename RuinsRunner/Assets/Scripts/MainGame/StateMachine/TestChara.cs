using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestChara : MonoBehaviour
{
    StateMachine state;

    // Start is called before the first frame update
    void Start()
    {
        //初期化
        state = new StateMachine(new TestNormal());
    }

    // Update is called once per frame
    void Update()
    {
        //更新処理
        state.Update(gameObject);
    }
}