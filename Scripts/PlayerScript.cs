using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
  


    public float speed = 10f;
    private float minX = -2.6f;
    private float maxX = 2.6f;
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        MovePLayer();
        
    }

    void MovePLayer()
    {
        float h = Input.GetAxisRaw("Horizontal");
        Vector2 temp = transform.position; 

        if (h > 0){
            //To move to the right
            temp.x += speed * Time.deltaTime;
        } else if (h < 0){
            //To move to the left
            temp.x -= speed * Time.deltaTime;
        }

        if(temp.x < minX)
        { //Border
            temp.x = minX;
        }

        if(temp.x > maxX)
        { //Border
            temp.x = maxX;  
        }
        transform.position = temp;



    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb")
        {
            Time.timeScale = 0f;
            SceneManager.LoadSceneAsync("AfterGame");
        }

    }
}

