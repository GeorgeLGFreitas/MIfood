using UnityEngine;
using UnityEngine.Events;

public class movimentoenm : Action
{
    public Rigidbody2D rb;
    public float p, movi;
    void Start()
    {
        if (movi == 1)
            rb.MovePosition(rb.position + Vector2.right * p);
        else if (movi == 2)
            rb.MovePosition(rb.position + Vector2.left * p);
        else if (movi == 3)
            rb.MovePosition(rb.position + Vector2.up * p);
        else if (movi == 4)
            rb.MovePosition(rb.position + Vector2.down * p);
    }
    public override bool ExecuteAction(GameObject dataObject)
    {
        Start();
        return (true);
    }
}

