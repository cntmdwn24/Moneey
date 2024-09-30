using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WatermelonGOGameOverUI : MonoBehaviour
{
    public static WatermelonGOGameOverUI Instance { get; private set; }
    [SerializeField] private TextMeshProUGUI maxBallText;
    [SerializeField] private TextMeshProUGUI playTimeText;
    [SerializeField] private Button reStartButton;
    [SerializeField] private Button mainMenuButton;

    private void Awake()
    {
        Instance = this;
        reStartButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("WatermelonGO!Game");
        });
        mainMenuButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Main");
        });
        Hide();
    }

    private void Update()
    {
        PlayTime();
        MaxBall();
    }

    private void PlayTime()
    {
        playTimeText.text =
            $"{(Convert.ToInt32(WatermelonGOObjectManager.Instance.playTime) / 60).ToString()} : {(Convert.ToInt32(WatermelonGOObjectManager.Instance.playTime) % 60).ToString()}";
    }

    private void MaxBall()
    {
        switch (WatermelonGOObjectManager.Instance.maxindex)
        {
            case 0:
                maxBallText.text = "max Ball : Green";
                break;
            case 1:
                maxBallText.text = "max Ball : Yellow";
                break;
            case 2:
                maxBallText.text = "max Ball : Red";
                break;
            case 3:
                maxBallText.text = "max Ball : Pink";
                break;
            case 4:
                maxBallText.text = "max Ball : Purple";
                break;
            case 5:
                maxBallText.text = "max Ball : Blue";
                break;
            case 6:
                maxBallText.text = "max Ball : Sky Blue";
                break;
            case 7:
                maxBallText.text = "max Ball : Dark Purple";
                break;
            case 8:
                maxBallText.text = "max Ball : Brown";
                break;
            case 9:
                maxBallText.text = "max Ball : Orange";
                break;
            case 10:
                maxBallText.text = "max Ball : Dark Green";
                break;
        }
        
        //maxBallText.text =
    }
    
    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
