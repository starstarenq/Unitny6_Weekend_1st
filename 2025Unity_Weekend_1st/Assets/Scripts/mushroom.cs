using UnityEngine;

public class Mushroom : MonoBehaviour
{

    // transform�̵����� �¿�� �����̴� �ڵ带 �������.
    // ���� �浹�� �� �ִ� ��ü�� ������ � "�̺�Ʈ"�� �߻��ؾ��Ѵ�.

    public float speed = 5f;
    public int direction = 1;
   

    // OnCollisionEnter2D �Լ��� �� ���� Rigidbody2D ������Ʈ�� ���������� �浹���� �� ȣ��˴ϴ�.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �浹�� ������Ʈ�� �±װ� "Mario"���� Ȯ���մϴ�.
        // ������ ������Ʈ�� "Mario" �±׸� �̸� �����صξ�� �մϴ�.



        if (collision.gameObject.CompareTag("Wall"))
        {
            // �浹���� �� ������ �̵� ������ �ݴ�� �ٲߴϴ�.
            direction = -direction;
        }

        if (collision.gameObject.CompareTag("Mario"))
        {
            // �� ��ũ��Ʈ�� �پ��ִ� Mushroom ������Ʈ�� �ı��մϴ�.
            // ������ ������� ȿ���� �ݴϴ�.
            Destroy(gameObject);
        }
    }

// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {
        int rand = UnityEngine.Random.Range(0, 2);
        if(rand == 0)
        {
            direction = -2;

        }
        else          if (rand == 1)
        {     direction = 2;
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(direction, 0, 0) * speed * Time.deltaTime;
    }
}
