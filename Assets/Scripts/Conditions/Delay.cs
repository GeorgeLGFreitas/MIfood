using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Playground/Conditions/Delay")]
public class Delay: ConditionBase
{
    public float initialDelay = 0f;

    private void Start()
    {
      
    }


    private void Update()
    {
        if (Time.time == initialDelay)
        {
            ExecuteAllActions(null);
        }
    }
}