using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hotbar : InventoryHandler
{

    public Image Slot1;
    public Image Slot2;
    public Image Slot3;
    public Image Slot4;
    public Image Slot5;

    Image previousSlot;

    void Start()
    {
        previousSlot = Slot1;
        HideSlots(Slot1);
        SetSlot(1);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            HideSlots(Slot1);
            SetSlot(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            HideSlots(Slot2);
            SetSlot(2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            HideSlots(Slot3);
            SetSlot(3);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {

            HideSlots(Slot4);
            SetSlot(4);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {

            HideSlots(Slot5);
            SetSlot(5);
        }

    }

    void HideSlots(Image currentSlot)
    {
        //unselected = (0, 0, 0, 50);
        //selected = (255, 255, 255, 50);

        previousSlot.GetComponent<Image>().color = new Color32(0, 0, 0, 50);
        currentSlot.GetComponent<Image>().color = new Color32(255, 255, 255, 50);
        previousSlot = currentSlot;
    }
}
