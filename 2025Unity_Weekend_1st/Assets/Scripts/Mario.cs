using UnityEngine;
using UnityEngine.InputSystem;

public class Mario : MonoBehaviour
{
   public float speed = 5f;
    public float JumpForce = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Mario 이동 구현 - A,D키를 눌러서 좌우로 움직이고 싶다. space키를 누르면 점프도 하고 싶다.
    // Update함수안에서 실행할 수 있게 해줘, speed와 JumpForce를 사용해서 기능을 구현해줘.
    // Tranform이동 방식, Rigibody 방식으로 이동
    // class 이름 Mario 만들어달라
    // RIgidbody2d게임이다.
    // 땅을 밟았을 때만 점프할 수 있게.



    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
            transform.position = transform.position + new Vector3(0, JumpForce, 0) * Time.deltaTime;
        }
        transform.position = transform.position + new Vector3(x, 0, 0) * speed * Time.deltaTime;
    }
}
