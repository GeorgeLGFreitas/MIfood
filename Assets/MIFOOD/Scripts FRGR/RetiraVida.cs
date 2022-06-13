using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Playground/Conditions/Condition Area")]
public class RetiraVida : ConditionBase
{
    
    public float frequency = 1f;
    
    public ColliderEventTypes eventType = ColliderEventTypes.Enter;



    private float lastTimeTriggerStayCalled;


    // This function will be called at the beginning
    void Start()
    {
        lastTimeTriggerStayCalled = -frequency;
    }


    //This will create a dialog window asking for which dialog to add
    private void Reset()
    {
        Utils.Collider2DDialogWindow(this.gameObject, true);
    }



    //this function is called every time another collider enters this trigger
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //is this the type of event we need?
        if (eventType == ColliderEventTypes.Enter)
        {

            //check for the tag of the object which entered the area, if necessary
            if (otherCollider.CompareTag(filterTag)
                || !filterByTag)
            {
                GameController.vidas--;
                ExecuteAllActions(otherCollider.gameObject);
            }
        }
    }



    // This will be called EVERY FRAME when something stays inside the trigger collider
    void OnTriggerStay2D(Collider2D otherCollider)
    {
        //is this the type of event we need?
        if (eventType == ColliderEventTypes.StayInside
            && Time.time >= lastTimeTriggerStayCalled + frequency) //check also the frequency
        {

            //check for the tag of the object which entered the area, if necessary
            if (otherCollider.CompareTag(filterTag)
                || !filterByTag)
            {
                ExecuteAllActions(otherCollider.gameObject);
                lastTimeTriggerStayCalled = Time.time;
            }
        }
    }



    //this function is called every time another collider exits this trigger
    private void OnTriggerExit2D(Collider2D otherCollider)
    {
        //is this the type of event we need?
        if (eventType == ColliderEventTypes.Exit)
        {

            //check for the tag of the object which entered the area, if necessary
            if (otherCollider.CompareTag(filterTag)
                || !filterByTag)
            {
                ExecuteAllActions(otherCollider.gameObject);
            }
        }
    }



    public enum ColliderEventTypes
    {
        Enter,
        Exit,
        StayInside
    }


}








