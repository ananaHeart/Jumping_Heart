using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heartscript : MonoBehaviour
{
    public Rigidbody2D myHeart;
    public float flapStrength;
    public logicmanager logic;
    public bool heartIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Heart Anana";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicmanager>();
    }
     
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && heartIsAlive)
        { 
            myHeart.velocity = Vector3.up * flapStrength;
        }
   
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOverScreen();
        heartIsAlive = false;
    }
}
