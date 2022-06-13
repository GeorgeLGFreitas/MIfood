using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFeno : Action
{
    public Animator animator;
  
    public override bool ExecuteAction(GameObject otherObject)
    {
        
        animator.SetInteger("Trigger Feno", 1);
        return true;

    }

}
