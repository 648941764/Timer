using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockController : MonoBehaviour
{
    public Transform hour;
    public Transform minute;
    public Transform second;

    private void Update()
    {
      hour.localRotation = Quaternion.Euler(0f, DateTime.Now.Hour*30, 0f);
      minute.localRotation = Quaternion.Euler(0f, DateTime.Now.Minute * 6, 0f);
      second.localRotation = Quaternion.Euler(0f, DateTime.Now.Second *6, 0f);
    }
}
