using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class middlepipeCode : MonoBehaviour
{
    public logicmanager logics;
    void Start()
    {
        logics = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicmanager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        logics.addScore(1);
    }

}
