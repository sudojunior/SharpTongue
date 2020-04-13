using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDontDestroyOnLoad : MonoBehaviour
{
    void OnEnable()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
