using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButton : MonoBehaviour
{
    // ���� ������ public, private + ��ȯ���� Ÿ�� ���� void, int, string + ������ �̸�
    public void ButtonPlay()
    {
        Debug.Log("������ �����մϴ�.");
        SceneManager.LoadScene(1);

    }
    public void ButtonLoad()
    {
        Debug.Log("������ �ҷ��ɴϴ�.");
    }
    public void ButtonSettings()
    {
        Debug.Log("����â�� �����մϴ�");
    }
    public void ButtonInformation()
    {
        Debug.Log("���� ���� â�� �����մϴ�.");
    }
    public void ButtonNews()
    {
        Debug.Log("���� �ҽ��� �˷��帱�Կ�");
    }
    public void ButtonCredit()
    {
        Debug.Log("�����ڵ�");
    }
}
