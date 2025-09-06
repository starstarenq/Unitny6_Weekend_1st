using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // �̵� �ӵ� ���� ����
    public float moveSpeed = 5f;

    // Rigidbody2D ������Ʈ ����
    private Rigidbody2D rb;

    void Start()
    {
        // ���� ���� ��, ������Ʈ�� �ִ� Rigidbody2D ������Ʈ�� �����ɴϴ�.
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // 'Horizontal' (A, D, ����/������ ����Ű) �� 'Vertical' (W, S, ��/�Ʒ� ����Ű) �Է� ���� �����ɴϴ�.
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // �Է� ���� ����Ͽ� 2D �̵� ���͸� �����մϴ�.
        Vector2 movement = new Vector2(moveX, moveY);

        // Rigidbody2D�� �ӵ��� �����Ͽ� ������Ʈ�� �����Դϴ�.
        // movement.normalized�� �밢������ �̵��� �� �ӵ��� �������� ���� �����մϴ�.
        // �̴� �̵� ������ ���̸� 1�� ����� ��� ���⿡�� ������ �ӵ��� �����ϰ� �մϴ�.
        rb.velocity = movement.normalized * moveSpeed;
    }
}