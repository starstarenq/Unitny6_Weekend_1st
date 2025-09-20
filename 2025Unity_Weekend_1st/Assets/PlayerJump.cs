using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rigidbody2D; // ������Ʈ ������ ���� ����� rigidbody2D ������ �̿��ؼ� ����ϰڴ�.

    [SerializeField] float jumppower = 5;
    
    [SerializeField] Vector2 dir;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] float groundCheckDistance = 2f;
    // �÷��̾� ���ӿ�����Ʈ �ȿ� �ִ� Rigidbody2D ������Ʈ�� rigidbody2D�ȿ� �����ϰ�ʹ�.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        //rigidbody2D.AddForce(dir.normalized * jumppower, ForceMode2D.Impulse);
        //rigidbody2D.AddForce(Vector2.right * 3, ForceMode2D.Impulse);
        //rigidbody2D.AddForce(Vector2.left * 3, ForceMode2D.Impulse);
        //rigidbody2D.AddForce(Vector2.down * 5, ForceMode2D.Impulse);
        //

    }

    // AddForce : ���߰�. ���� -> ���� �� ���Ѵ�.

    // Update is called once per frame
    void Update()
    {
        // rigidbody2D.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        // �����̽��� �������� ����.
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded() )
        {
            rigidbody2D.AddForce(dir.normalized * jumppower, ForceMode2D.Impulse);
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
