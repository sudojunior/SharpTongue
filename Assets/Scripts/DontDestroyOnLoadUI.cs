using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoadUI : MonoBehaviour
{
    public static GameObject UICanvas;

    public void OnEnable()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
