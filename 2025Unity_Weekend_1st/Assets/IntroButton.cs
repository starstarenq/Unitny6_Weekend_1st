using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButton : MonoBehaviour
{
    // 접근 지정자 public, private + 반환값의 타입 선언 void, int, string + 정수의 이름
    public void ButtonPlay()
    {
        Debug.Log("게임을 시작합니다.");
        SceneManager.LoadScene(1);

    }
    public void ButtonLoad()
    {
        Debug.Log("게임을 불러옵니다.");
    }
    public void ButtonSettings()
    {
        Debug.Log("설정창을 실행합니다");
    }
    public void ButtonInformation()
    {
        Debug.Log("게임 정보 창을 실행합니다.");
    }
    public void ButtonNews()
    {
        Debug.Log("게임 소식을 알려드릴게요");
    }
    public void ButtonCredit()
    {
        Debug.Log("제작자들");
    }
}
