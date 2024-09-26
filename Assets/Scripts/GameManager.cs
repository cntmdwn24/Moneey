using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // 씬 관리를 위해 추가

public class GameManager : MonoBehaviour
{
    [SerializeField] private Button WatermelonGOButton;
    [SerializeField] private Button memoryButton;
    [SerializeField] private Button reactionSpeedButton;
    [SerializeField] private Button HiddenPicturesButton;

    private void Awake()
    {
        WatermelonGOButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("WatermelonGO!Game"); // 여기에 원하는 씬 이름을 입력하세요
        });
        memoryButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MemoryGame"); // 여기에 원하는 씬 이름을 입력하세요
        });
        reactionSpeedButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("ReactionSpeedGame");
        });
        HiddenPicturesButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Hidden Pictures");
        });
        
    }
}