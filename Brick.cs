using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

    public int health;
    public Sprite[] sprites;

    private void Awake()
    {
        GameManager.brickCount++;
        print(GameManager.brickCount);
        GetComponent<SpriteRenderer>().sprite = sprites[health];
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;
        GetComponent<SpriteRenderer>().sprite = sprites[health];

        if (health <= 0)
        {                   //if our health gets to zero
            GameManager.brickCount--;
            print(GameManager.brickCount);
            if (GameManager.brickCount == 0)
            {
                FindObjectOfType<GameManager>().LoadNextLevel();
            }
            Destroy(gameObject);            //then destroy this object
        }


    }


}
