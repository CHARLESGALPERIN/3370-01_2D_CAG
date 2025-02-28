using UnityEngine;

public class movement : MonoBehaviour
{
    float speed_x;
    float speed_y;
    public float speed_g;
    Rigidbody2D rb;
    private bool isFacingRight = true;
    
    public float jump;
    public Transform inGround;
    public LayerMask groundLayer;
    bool isGrounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCapsule(inGround.position, new Vector2(3f, 2f), CapsuleDirection2D.Horizontal, 0, groundLayer);
        
        speed_x = Input.GetAxisRaw("Horizontal") * speed_g;
        rb.linearVelocity = new Vector2(speed_x, rb.linearVelocity.y); 
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector2(rb.linearVelocity.x, jump));
        }
        Flip();
        //Debug.Log(isGrounded);
    }

    private void Flip()
    {
        if (isFacingRight && speed_x > 0f || !isFacingRight && speed_x < 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

}
