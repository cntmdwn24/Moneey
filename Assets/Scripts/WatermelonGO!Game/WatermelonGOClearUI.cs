using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WatermelonGOClearUI : MonoBehaviour
{
    public static WatermelonGOClearUI Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI playTimeText;
    [SerializeField] private Button reStartButton;
    [SerializeField] private Button mainMenuButton;

    private void Awake()
    {
        Instance = this;
        Hide();
        reStartButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("WatermelonGO!Game");
        });
        mainMenuButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Main");
        });
    }

    private void Update()
    {
        playTimeText.text = $"{(Convert.ToInt32(WatermelonGOObjectManager.Instance.playTime) / 60).ToString()} : {(Convert.ToInt32(WatermelonGOObjectManager.Instance.playTime) % 60).ToString()}";
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
