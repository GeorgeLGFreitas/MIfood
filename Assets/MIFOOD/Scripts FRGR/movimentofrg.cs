using UnityEngine;

public class movimentofrg : MonoBehaviour
{
    public Rigidbody2D rb;
    public float p, o;
    public AudioClip move;
    public Animator animator;
    public Camera MainCamera;
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    void Start()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right * p);
            SoundManager.instance.RandomizeSfx(move);

            animator.SetInteger("dir", 1);

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left * p);
            SoundManager.instance.RandomizeSfx(move);

            animator.SetInteger("dir", 3);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up * p);
            SoundManager.instance.RandomizeSfx(move);

            animator.SetInteger("dir", 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down * p);
            SoundManager.instance.RandomizeSfx(move);

            animator.SetInteger("dir", 2);
        }
        //if (Input.GetKeyDown(KeyCode.W))
        {
            //rb.MovePosition(rb.position + Vector2.left * o + Vector2.up * o);
            //SoundManager.instance.RandomizeSfx(move);
        }
        //if (Input.GetKeyDown(KeyCode.D))
        {
            // rb.MovePosition(rb.position + Vector2.right * o + Vector2.up * o);
            // SoundManager.instance.RandomizeSfx(move);
        }
        // if (Input.GetKeyDown(KeyCode.A))
        {
            // rb.MovePosition(rb.position + Vector2.left * o + Vector2.down * o);
            //SoundManager.instance.RandomizeSfx(move);
        }
        //if (Input.GetKeyDown(KeyCode.S))
        {
            //rb.MovePosition(rb.position + Vector2.right * o + Vector2.down * o);
            //SoundManager.instance.RandomizeSfx(move);
        }

    }

    private void Update()
    {
        Start();
    }
}
