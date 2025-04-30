using UnityEngine;

public class Flip : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    public bool isFacingRight = true;
    private SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        //Vector2 force = new Vector2 (moveInput * moveForce, 0f);//Khởi tạo vector 
        if (moveInput > 0)
        {
            sr.flipX = false;
        }
        else if (moveInput < 0)
        {
            sr.flipX = true;
        }

    }
}
