using UnityEngine;

public class Mushroom : MonoBehaviour
{

    // transform이동으로 좌우로 움직이는 코드를 만들어줘.
    // 옆에 충돌할 수 있는 물체가 있으면 어떤 "이벤트"가 발생해야한다.

    public float speed = 5f;
    public int direction = 1;
   

    // OnCollisionEnter2D 함수는 두 개의 Rigidbody2D 오브젝트가 물리적으로 충돌했을 때 호출됩니다.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌한 오브젝트의 태그가 "Mario"인지 확인합니다.
        // 마리오 오브젝트에 "Mario" 태그를 미리 설정해두어야 합니다.



        if (collision.gameObject.CompareTag("Wall"))
        {
            // 충돌했을 때 버섯의 이동 방향을 반대로 바꿉니다.
            direction = -direction;
        }

        if (collision.gameObject.CompareTag("Mario"))
        {
            // 이 스크립트가 붙어있는 Mushroom 오브젝트를 파괴합니다.
            // 버섯이 사라지는 효과를 줍니다.
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
