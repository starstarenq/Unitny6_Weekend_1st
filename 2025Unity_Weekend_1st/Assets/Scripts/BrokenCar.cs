using UnityEngine;

public class BrokenCar : MonoBehaviour
{

    Rigidbody2D rigidbody2D;
    [SerializeField] Vector2 moveDir;
    [SerializeField] float moveSpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.linearVelocity = moveDir.normalized * moveSpeed;
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("플레이어가 충돌하여 게임이 종료됩니다.");


        }
    }
}
