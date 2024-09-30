using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatermelonGOGameOutLine : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "WatermelonGO!Game circle 1")
        {
            if (other.gameObject.GetComponent<WatermelonGOCircle>().dss==true)
            {
                WatermelonGOGameOverUI.Instance.Show();
                Time.timeScale = 0;
            }
        }
        if (other.gameObject.tag == "WatermelonGO!Game circle 2")
        {
            if (other.gameObject.GetComponent<WatermelonGOCircle>().dss==true)
            {
                WatermelonGOGameOverUI.Instance.Show();
                Time.timeScale = 0;
            }
        } if (other.gameObject.tag == "WatermelonGO!Game circle 3")
        {
            if (other.gameObject.GetComponent<WatermelonGOCircle>().dss==true)
            {
                WatermelonGOGameOverUI.Instance.Show();
                Time.timeScale = 0;
            }
        } if (other.gameObject.tag == "WatermelonGO!Game circle 4")
        {
            if (other.gameObject.GetComponent<WatermelonGOCircle>().dss==true)
            {
                WatermelonGOGameOverUI.Instance.Show();
                Time.timeScale = 0;
            }
        } if (other.gameObject.tag == "WatermelonGO!Game circle 5")
        {
            if (other.gameObject.GetComponent<WatermelonGOCircle>().dss==true)
            {
                WatermelonGOGameOverUI.Instance.Show();
                Time.timeScale = 0;
            }
        } if (other.gameObject.tag == "WatermelonGO!Game circle 6")
        {
            if (other.gameObject.GetComponent<WatermelonGOCircle>().dss==true)
            {
                WatermelonGOGameOverUI.Instance.Show();
                Time.timeScale = 0;
            }
        } if (other.gameObject.tag == "WatermelonGO!Game circle 7")
        {
            if (other.gameObject.GetComponent<WatermelonGOCircle>().dss==true)
            {
                WatermelonGOGameOverUI.Instance.Show();
                Time.timeScale = 0;
            }
        } if (other.gameObject.tag == "WatermelonGO!Game circle 8")
        {
            if (other.gameObject.GetComponent<WatermelonGOCircle>().dss==true)
            {
                WatermelonGOGameOverUI.Instance.Show();
                Time.timeScale = 0;
            }
        } if (other.gameObject.tag == "WatermelonGO!Game circle 9")
        {
            if (other.gameObject.GetComponent<WatermelonGOCircle>().dss==true)
            {
                WatermelonGOGameOverUI.Instance.Show();
                Time.timeScale = 0;
            }
        } if (other.gameObject.tag == "WatermelonGO!Game circle 10")
        {
            if (other.gameObject.GetComponent<WatermelonGOCircle>().dss==true)
            {
                WatermelonGOGameOverUI.Instance.Show();
                Time.timeScale = 0;
            }
        }
        
        
        
        
        
        
        
        
        
    }
}
