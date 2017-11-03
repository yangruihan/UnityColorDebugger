using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            ColorDebug.Log("-----" + i + "-----", ColorDebug.GetRandomColor());
        }
    }
}
