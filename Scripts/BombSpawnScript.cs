using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Build.Content;
using UnityEngine;

public class BombSpawnScript : MonoBehaviour
{
    public GameObject Bomb;


    private float minX = -2.6f;
    private float maxX = 2.6f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SapwnBombs());
    }


    IEnumerator SapwnBombs()
    {
        yield return new WaitForSeconds(Random.Range(0f,.5f));

        Instantiate(Bomb, new Vector2(Random.Range(minX, maxX), transform.position.y), Quaternion.identity);

        StartCoroutine(SapwnBombs());
    }
    
    
    
    
    
    // Update is called once per frame
    void Update()
    {
       
    }
}
