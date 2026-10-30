using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerControllerMove : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody2D rb;
    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public LayerMask groundLayer;
    public float jumForce=5f;
    private bool isGround;
    private bool isFacingRigh = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
        isGround = Physics2D.OverlapCircle(groundCheck.position, groundRadius,groundLayer);
        if (Input.GetKeyDown(KeyCode.Space)&&isGround)
        {
         rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumForce);
        }
        if((horizontal>0&&!isFacingRigh)||(horizontal<0&&isFacingRigh))
        {
            Flip();
        }
    }
    private void OnDrawGizmos()
    {
        if(groundCheck!=null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(groundCheck.position, groundRadius);
        }
    }
    void Flip()
    {
        isFacingRigh = !isFacingRigh;
        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
