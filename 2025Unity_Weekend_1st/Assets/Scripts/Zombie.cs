using UnityEngine;

public class Zombie : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    [SerializeField] Vector2 moveDir;
    [SerializeField] float moveSpeed;
    [SerializeField] float jumptiming = 2;
    [SerializeField] float jumppower = 5;
    [SerializeField] float groundCheckDistance = 2f;
    [SerializeField] Vector2 dir;
    [SerializeField] LayerMask groundLayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.linearVelocity = moveDir.normalized * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
            rigidbody2D.AddForce(dir.normalized * jumppower, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("플레이어가 충돌하여 게임이 종료됩니다.");


        }
    }
    bool IsGrounded()
    {
        return Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistance, groundLayer);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, transform.position + (Vector3)(Vector2.down * groundCheckDistance));
    }
}
