using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class HiddenPictureGame : MonoBehaviour
{
    public Animator animator;
    
    [SerializeField] private Button[] picturesButton;
    [SerializeField] private Sprite[] image;
    [SerializeField] private bool[] no;
    private Color col;
    private int clickCount = 0;
    private int c1, c2;
    private Image m1, m2;
    private int[] pictureswin = {0,};
    private void Awake()
    {
        for (int i = 0; i < 32; i++)
        {
            int a = i;
            picturesButton[i].onClick.AddListener(() =>
            {
                animator = picturesButton[a].GetComponentInChildren<Animator>();
                picturesButton[a].interactable = false;
                //Image im = picturesButton[a].GetComponentsInChildren<Image>();
                //im.enabled = false;
                animator.SetTrigger("click");
                clickCount += 1;
                if (clickCount == 1)
                {
                    c1 = a;
                    //m1 = im;
                }

                if (clickCount == 2)
                {
                    c2 = a;
                    //m2 = im;
                }
            });
        }
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
            }
            else
            {
                for (int i = 0; i < 32; i++)
                {
                    int a = i;
                    if (picturesButton[a].interactable == false && no[a] == false)
                    {
                        //m1.enabled = false;
                        //m2.enabled = false;
                        animator.SetTrigger("click");
                        picturesButton[a].interactable = true;
                    }
                }
            }
        }
    }
}
