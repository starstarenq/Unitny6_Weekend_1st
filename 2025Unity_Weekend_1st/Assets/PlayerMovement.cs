using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // 이동 속도 조절 변수
    public float moveSpeed = 5f;

    // Rigidbody2D 컴포넌트 참조
    private Rigidbody2D rb;

    void Start()
    {
        // 게임 시작 시, 오브젝트에 있는 Rigidbody2D 컴포넌트를 가져옵니다.
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // 'Horizontal' (A, D, 왼쪽/오른쪽 방향키) 및 'Vertical' (W, S, 위/아래 방향키) 입력 값을 가져옵니다.
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // 입력 값을 사용하여 2D 이동 벡터를 생성합니다.
        Vector2 movement = new Vector2(moveX, moveY);

        // Rigidbody2D의 속도를 설정하여 오브젝트를 움직입니다.
        // movement.normalized는 대각선으로 이동할 때 속도가 빨라지는 것을 방지합니다.
        // 이는 이동 벡터의 길이를 1로 만들어 모든 방향에서 동일한 속도를 유지하게 합니다.
        rb.velocity = movement.normalized * moveSpeed;
    }
}