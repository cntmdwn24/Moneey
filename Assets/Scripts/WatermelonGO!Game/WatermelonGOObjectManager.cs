using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    private int inull;
    private int index = 0;

    public GameObject[] clire = new GameObject[99999];
    public float[] clireindex = new float[99999];

    private void Awake()
    {
        Instance = this;
        
        for (int i = 0; i < clire.Length; i++)
        {
            clire[i] = dnull;
            clireindex[i] = inull;
        }
        
        clire[index] = Instantiate(prefabObject[0], new Vector3(0, INIT_T_POS, 0), Quaternion.identity) as GameObject;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {
            ObjectMove();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            ObjectDrop();
            index++;
            clire[index] = Instantiate(prefabObject[Random.Range(0,3)], new Vector3(0, INIT_T_POS, 0), Quaternion.identity);
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        yield return 1f;
        clireindex[index] = 1f;
    }

    private void ObjectMove()
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
    
    private void ObjectDrop()
    {
        clire[index].GetComponentInChildren<Rigidbody2D>().simulated = true;
        clire[index].GetComponentInChildren<CircleCollider2D>().enabled=true;
    }

    
}
