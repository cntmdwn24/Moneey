using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReactionSpeedGameRank : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Button lobby;
    [SerializeField] private Button reStart;

    private void Awake()
    {
        lobby.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Main");
        });
        reStart.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("ReactionSpeedGame");
        });
    }

    private void Update()
    {
        if (ReactionSpeedGame.Instance.reactionTime < 100)
        {
            text.text = "Are you a god?";
        }
        else if (ReactionSpeedGame.Instance.reactionTime < 200)
        {
            text.text = "Dingshin is a rabbit";
        }
        else if (ReactionSpeedGame.Instance.reactionTime < 300)
        {
            text.text = "Dingshin is a human";
        }
        else if (ReactionSpeedGame.Instance.reactionTime < 400)
        {
            text.text = "Dingshin is a snail";
        }
        else if(ReactionSpeedGame.Instance.reactionTime < 500)
        {
            text.text = "Dingshin is a sloth";
        }
        else if(ReactionSpeedGame.Instance.reactionTime > 500)
        {
            text.text = "Dingshin is a turtle";
        }
    }
}
