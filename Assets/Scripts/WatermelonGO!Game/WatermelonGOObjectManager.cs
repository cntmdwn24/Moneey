using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class WatermelonGOObjectManager : MonoBehaviour
{
    public static WatermelonGOObjectManager Instance { get; private set; }
    
    private static readonly float INIT_T_POS = 4;
    private static readonly int GRAVITY_SCALE = 1;
    
    
    [SerializeField] public GameObject[] prefabObject = new GameObject[10];
    [SerializeField] private GameObject spwanObject;
    [SerializeField] public GameObject[] Outline;
    private GameObject dnull;
    private int index = 0;
    private bool move = true;

    public float playTime;
    public int maxindex;
    public bool drop = false;

    public GameObject[] clire = new GameObject[99999];

    private void Awake()
    {
        Instance = this;
        
        for (int i = 0; i < clire.Length; i++)
        {
            clire[i] = dnull;
        }
        
        clire[index] = Instantiate(prefabObject[0], new Vector3(0, INIT_T_POS, 0), Quaternion.identity) as GameObject;
    }

    private void Update()
    {
        Click();
        PlayTime();
    }

    private void Click()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {
            ObjectMove();
            
        }
        else if (Input.GetMouseButtonUp(0))
        {
            ObjectDrop();
        }
    }
    

    private void ObjectMove()
    {
        if (move)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            mousePos.y = clire[index].transform.position.y;
            
            clire[index].transform.position = mousePos + new Vector3(0, 0, 10);
            
            if (clire[index].transform.position.x < -2.32f)
            {
                clire[index].transform.position = new Vector3(-2.32f, 4, 0);
            }
            if (clire[index].transform.position.x > 2.32f)
            {
                clire[index].transform.position = new Vector3(2.32f, 4, 0);
            } 
        }
    }
    
    private void ObjectDrop()
    {
        if (move)
        {
            clire[index].GetComponentInChildren<Rigidbody2D>().simulated = true;
            clire[index].GetComponentInChildren<CircleCollider2D>().enabled = true;
            index++;
            move = false;
            StartCoroutine(II());
        }
    }

    IEnumerator II()
    {
        yield return new WaitForSeconds(1f);
        drop = true;
        StartCoroutine(IIs());
    }
    IEnumerator IIs()
    {
        yield return new WaitForSeconds(.5f);
        drop = false;
        move = true;
        clire[index] = Instantiate(prefabObject[Random.Range(0,3)], new Vector3(0, INIT_T_POS, 0), Quaternion.identity);
    }

    private void PlayTime()
    {
        playTime += Time.deltaTime;
    }


}
