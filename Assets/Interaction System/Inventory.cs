using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour
{
    public bool hasPart = false;

    private void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame) hasPart = !hasPart;
    }
}
