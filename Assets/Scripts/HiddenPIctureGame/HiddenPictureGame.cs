using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class HiddenPictureGame : MonoBehaviour
{
    public Animator animator;
    
    [SerializeField] private Button[] picturesButton;
    [SerializeField] private Sprite[] image;
    [SerializeField] private bool[] no;
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private int[] cont;
    [SerializeField] private GameObject clear;
    [SerializeField] private Button lobbyButton;
    [SerializeField] private Button restartButton;
    private Color col;
    private int clickCount = 0;
    private int c1, c2;
    private Image m1, m2;
    private int finsh;
    
    private void Awake()
    {
        for (int i = 0; i < 32; i++)
        {
            int b = i;
            Image a = picturesButton[b].transform.GetChild(0).GetComponent<Image>();
            int d = Random.Range(0, 16);
            if (cont[d] == 2)
            {
                i--;
                continue;
            }
            else
            {
                a.sprite = sprites[d];
                cont[d]++;
            }
            
        }
        
        for (int i = 0; i < 32; i++)
        {
            int a = i;
            picturesButton[i].onClick.AddListener(() =>
            {
                animator = picturesButton[a].GetComponentInChildren<Animator>();
                picturesButton[a].interactable = false;
                Image im = picturesButton[a].transform.GetChild(0).GetComponent<Image>();
                im.enabled = true;
                animator.SetTrigger("click");
                clickCount += 1;
                if (clickCount == 1)
                {
                    c1 = a;
                    m1 = im;
                }

                if (clickCount == 2)
                {
                    c2 = a;
                    m2 = im;
                }
            });
        }
        lobbyButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Main");
        });
        restartButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Hidden Pictures");
        });
    }

    private void Update()
    {
        if (clickCount == 2)
        {
            clickCount = 0;

            if (m1.sprite == m2.sprite)
            {
                no[c1] = true;
                no[c2] = true;
                finsh++;
            }
            else
            {
                for (int i = 0; i < 32; i++)
                {
                    int a = i;
                    if (picturesButton[a].interactable == false && no[a] == false)
                    {
                        StartCoroutine("slow");
                        animator.SetTrigger("click");
                        picturesButton[a].interactable = true;
                    }
                }
            }
        }

        if (finsh == 16)
        {
            clear.SetActive(true);
        }
    }

    IEnumerator slow()
    {
        yield return new WaitForSecondsRealtime(0.3f);
        m1.enabled = false;
        m2.enabled = false;
        Animator an = picturesButton[c1].GetComponent<Animator>();
        an.SetTrigger("click");
    }
}
