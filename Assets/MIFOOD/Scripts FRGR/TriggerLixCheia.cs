using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLixCheia : Action
{
    public Animator animator;
    int vari;
    public override bool ExecuteAction(GameObject otherObject)
    {
        vari = Random.Range(1, 3);
        animator.SetInteger("TriggerLixCheia", vari);
        return true;
    }
}
