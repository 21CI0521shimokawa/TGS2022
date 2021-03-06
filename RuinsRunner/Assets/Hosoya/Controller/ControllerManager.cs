using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerManager
{
    public static Vector2 GetGamepadStickL()
    {
        //倒した方向を取得
        Gamepad gamepad = Gamepad.current;

        Vector2 stickValue = Vector2.zero;

        if (gamepad != null)
        {
            stickValue = gamepad.leftStick.ReadValue();
        }


        //キー入力に応じて書き換え
        Keyboard keyboard = Keyboard.current;

        if (keyboard.rightArrowKey.isPressed) { stickValue.x += 1.0f; }
        if (keyboard.leftArrowKey.isPressed) { stickValue.x -= 1.0f; }
        if (keyboard.upArrowKey.isPressed) { stickValue.y += 1.0f; }
        if (keyboard.downArrowKey.isPressed) { stickValue.y -= 1.0f; }

        return stickValue;
    }
}
