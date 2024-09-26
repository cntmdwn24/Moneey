using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WatermelonGOCircle : MonoBehaviour
{
    public bool isMarge;
    private Collision2D deother;
    private int index = 0;
    
    
    
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "WatermelonGO!Game circle 1")
        {
            if (gameObject.tag == "WatermelonGO!Game circle 1")
            {
                index = 1;
                WatermelonGOCircle collision = other.gameObject.GetComponent<WatermelonGOCircle>();
                if (!isMarge && !collision.isMarge)
                {
                    deother = other;
                    float meX = transform.position.x;
                    float meY = transform.position.y;
                    float otherMeX = collision.transform.position.x;
                    float otherMeY = collision.transform.position.y;

                    if (meY < otherMeY || (meY == otherMeY && meX == otherMeX))
                    {
                        collision.Hide(transform.position);
                        Destroy(gameObject);
                    }
                }
            }
        }
        if (other.gameObject.tag == "WatermelonGO!Game circle 2")
        {
            if (gameObject.tag == "WatermelonGO!Game circle 2")
            {
                index = 2;
                WatermelonGOCircle collision = other.gameObject.GetComponent<WatermelonGOCircle>();
                if (!isMarge && !collision.isMarge)
                {
                    float meX = transform.position.x;
                    float meY = transform.position.y;
                    float otherMeX = collision.transform.position.x;
                    float otherMeY = collision.transform.position.y;

                    if (meY < otherMeY || (meY == otherMeY && meX == otherMeX))
                    {
                        collision.Hide(transform.position);
                        Destroy(gameObject);
                    }
                }
            }
        }
        if (other.gameObject.tag == "WatermelonGO!Game circle 3")
        {
            if (gameObject.tag == "WatermelonGO!Game circle 3")
            {
                index = 3;
                WatermelonGOCircle collision = other.gameObject.GetComponent<WatermelonGOCircle>();
                if (!isMarge && !collision.isMarge)
                {
                    float meX = transform.position.x;
                    float meY = transform.position.y;
                    float otherMeX = collision.transform.position.x;
                    float otherMeY = collision.transform.position.y;

                    if (meY < otherMeY || (meY == otherMeY && meX == otherMeX))
                    {
                        collision.Hide(transform.position);
                        Destroy(gameObject);
                    }
                }
            }
        }
        if (other.gameObject.tag == "WatermelonGO!Game circle 4")
        {
            if (gameObject.tag == "WatermelonGO!Game circle 4")
            {
                index = 4;
                WatermelonGOCircle collision = other.gameObject.GetComponent<WatermelonGOCircle>();
                if (!isMarge && !collision.isMarge)
                {
                    float meX = transform.position.x;
                    float meY = transform.position.y;
                    float otherMeX = collision.transform.position.x;
                    float otherMeY = collision.transform.position.y;

                    if (meY < otherMeY || (meY == otherMeY && meX == otherMeX))
                    {
                        collision.Hide(transform.position);
                        Destroy(gameObject);
                    }
                }
            }
        }
        if (other.gameObject.tag == "WatermelonGO!Game circle 5")
        {
            if (gameObject.tag == "WatermelonGO!Game circle 5")
            {
                index = 5;
                WatermelonGOCircle collision = other.gameObject.GetComponent<WatermelonGOCircle>();
                if (!isMarge && !collision.isMarge)
                {
                    float meX = transform.position.x;
                    float meY = transform.position.y;
                    float otherMeX = collision.transform.position.x;
                    float otherMeY = collision.transform.position.y;

                    if (meY < otherMeY || (meY == otherMeY && meX == otherMeX))
                    {
                        collision.Hide(transform.position);
                        Destroy(gameObject);
                    }
                }
            }
        }
        if (other.gameObject.tag == "WatermelonGO!Game circle 6")
        {
            if (gameObject.tag == "WatermelonGO!Game circle 6")
            {
                index = 6;
                WatermelonGOCircle collision = other.gameObject.GetComponent<WatermelonGOCircle>();
                if (!isMarge && !collision.isMarge)
                {
                    float meX = transform.position.x;
                    float meY = transform.position.y;
                    float otherMeX = collision.transform.position.x;
                    float otherMeY = collision.transform.position.y;

                    if (meY < otherMeY || (meY == otherMeY && meX == otherMeX))
                    {
                        collision.Hide(transform.position);
                        Destroy(gameObject);
                    }
                }
            }
        }
        if (other.gameObject.tag == "WatermelonGO!Game circle 7")
        {
            if (gameObject.tag == "WatermelonGO!Game circle 7")
            {
                index = 7;
                WatermelonGOCircle collision = other.gameObject.GetComponent<WatermelonGOCircle>();
                if (!isMarge && !collision.isMarge)
                {
                    float meX = transform.position.x;
                    float meY = transform.position.y;
                    float otherMeX = collision.transform.position.x;
                    float otherMeY = collision.transform.position.y;

                    if (meY < otherMeY || (meY == otherMeY && meX == otherMeX))
                    {
                        collision.Hide(transform.position);
                        Destroy(gameObject);
                    }
                }
            }
        }
        if (other.gameObject.tag == "WatermelonGO!Game circle 8")
        {
            if (gameObject.tag == "WatermelonGO!Game circle 8")
            {
                index = 8;
                WatermelonGOCircle collision = other.gameObject.GetComponent<WatermelonGOCircle>();
                if (!isMarge && !collision.isMarge)
                {
                    float meX = transform.position.x;
                    float meY = transform.position.y;
                    float otherMeX = collision.transform.position.x;
                    float otherMeY = collision.transform.position.y;

                    if (meY < otherMeY || (meY == otherMeY && meX == otherMeX))
                    {
                        collision.Hide(transform.position);
                        Destroy(gameObject);
                    }
                }
            }
        }
        if (other.gameObject.tag == "WatermelonGO!Game circle 9")
        {
            if (gameObject.tag == "WatermelonGO!Game circle 9")
            {
                index = 9;
                WatermelonGOCircle collision = other.gameObject.GetComponent<WatermelonGOCircle>();
                if (!isMarge && !collision.isMarge)
                {
                    float meX = transform.position.x;
                    float meY = transform.position.y;
                    float otherMeX = collision.transform.position.x;
                    float otherMeY = collision.transform.position.y;

                    if (meY < otherMeY || (meY == otherMeY && meX == otherMeX))
                    {
                        collision.Hide(transform.position);
                        Destroy(gameObject);
                    }
                }
            }
        }
        if (other.gameObject.tag == "WatermelonGO!Game circle 10")
        {
            if (gameObject.tag == "WatermelonGO!Game circle 10")
            {
                index = 10;
                WatermelonGOCircle collision = other.gameObject.GetComponent<WatermelonGOCircle>();
                if (!isMarge && !collision.isMarge)
                {
                    float meX = transform.position.x;
                    float meY = transform.position.y;
                    float otherMeX = collision.transform.position.x;
                    float otherMeY = collision.transform.position.y;

                    if (meY < otherMeY || (meY == otherMeY && meX == otherMeX))
                    {
                        collision.Hide(transform.position);
                        Destroy(gameObject);
                    }
                }
            }
        }
    }

    private void Hide(Vector3 targetPos)
    {
        isMarge = true;
        
        StartCoroutine(HideRoutine(targetPos));
    }

    IEnumerator HideRoutine(Vector3 tartget)
    {
        int frameCount = 0;
        
        while(frameCount < 20)
        {
            frameCount++;
            transform.position = Vector3.Lerp(transform.position, tartget, 0.1f); 
            yield return null;
        }
        
        isMarge = false;
        Destroy(gameObject);
        GameObject gameObject1 = Instantiate(WatermelonGOObjectManager.Instance.prefabObject[index], transform.position, Quaternion.identity);
        gameObject1.GetComponentInChildren<CircleCollider2D>().enabled=true;
        gameObject1.GetComponent<Rigidbody2D>().simulated = true;
    }
}
