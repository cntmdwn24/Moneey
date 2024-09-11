using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리를 위해 추가

public class GameManager : MonoBehaviour
{
    public void sex()
    {
        Debug.Log("sex");
        SceneManager.LoadScene("MemoryGame"); // 여기에 원하는 씬 이름을 입력하세요
    }

    public void sx()
    {
        Debug.Log("sex");
        SceneManager.LoadScene("Game"); // 여기에 원하는 씬 이름을 입력하세요
    }
}