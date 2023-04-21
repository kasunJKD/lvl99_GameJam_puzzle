using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : MonoBehaviour
{
    public static bool enableInput = true;

    void Update() {
        if (enableInput && Input.GetKeyDown(KeyCode.Space)) {
            // Do something
        }
    }

    public void DisableInput() {
        enableInput = false;
    }

    public void EnableInput() {
        enableInput = true;
    }
}
