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

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
