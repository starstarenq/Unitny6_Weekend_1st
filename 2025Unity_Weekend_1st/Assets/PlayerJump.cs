using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rigidbody2D; // 컴포넌트 부착한 물리 기능을 rigidbody2D 변수를 이용해서 사용하겠다.

    [SerializeField] float jumppower = 5;
    
    [SerializeField] Vector2 dir;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] float groundCheckDistance = 2f;
    // 플레이어 게임오브젝트 안에 있는 Rigidbody2D 컴포넌트를 rigidbody2D안에 저장하고싶다.

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

    // AddForce : 힘추가. 점프 -> 위로 힘 가한다.

    // Update is called once per frame
    void Update()
    {
        // rigidbody2D.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        // 스페이스바 눌렀을때 점프.
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
