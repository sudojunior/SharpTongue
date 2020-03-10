using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hotbar : InventoryHandler
{
    
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetSlot(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetSlot(2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetSlot(3);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SetSlot(4);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SetSlot(5);
        }

    }
}
