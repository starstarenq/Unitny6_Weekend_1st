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

    // Mario �̵� ���� - A,DŰ�� ������ �¿�� �����̰� �ʹ�. spaceŰ�� ������ ������ �ϰ� �ʹ�.
    // Update�Լ��ȿ��� ������ �� �ְ� ����, speed�� JumpForce�� ����ؼ� ����� ��������.
    // Tranform�̵� ���, Rigibody ������� �̵�
    // class �̸� Mario �����޶�
    // RIgidbody2d�����̴�.
    // ���� ����� ���� ������ �� �ְ�.



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
