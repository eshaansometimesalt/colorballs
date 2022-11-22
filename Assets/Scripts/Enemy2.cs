using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    
    public Transform spawnobject;
    public Player2 p2;
    public float win = 0f;
    
    void Start()
    {
        var sphereRenderer = spawnobject.GetComponent<Renderer>();
        
        
        float den = Random.Range(1,4);
        if(den == p2.den && den == 4){
            den = den - 1;
        }else if(den == p2.den){
            den = den + 1;

            
        }
        switch(den){
            case 1:
            sphereRenderer.material.SetColor("_Color", Color.blue);
            break;
            case 2:
            sphereRenderer.material.SetColor("_Color", Color.green);
            break;
            case 3:
            sphereRenderer.material.SetColor("_Color", Color.red);
            break;
            case 4:
            sphereRenderer.material.SetColor("_Color", Color.yellow);
            break;
        }
        Instantiate(spawnobject);
    float den = Random.Range(1,4);
        if(den == p2.den && den == 4){
            den = den - 1;
        }else if(den == p2.den){
            den = den + 1;
        }
        switch(den){
            case 1:
            sphereRenderer.material.SetColor("_Color", Color.blue);
            break;
            case 2:
            sphereRenderer.material.SetColor("_Color", Color.green);
            break;
            case 3:
            sphereRenderer.material.SetColor("_Color", Color.red);
            break;
            case 4:
            sphereRenderer.material.SetColor("_Color", Color.yellow);
            break;
        }
        Instantiate(spawnobject);
        float den = Random.Range(1,4);
        if(den == p2.den && den == 4){
            den = den - 1;
        }else if(den == p2.den){
            den = den + 1;
        }
        switch(den){
            case 1:
            sphereRenderer.material.SetColor("_Color", Color.blue);
            break;
            case 2:
            sphereRenderer.material.SetColor("_Color", Color.green);
            break;
            case 3:
            sphereRenderer.material.SetColor("_Color", Color.red);
            break;
            case 4:
            sphereRenderer.material.SetColor("_Color", Color.yellow);
            break;
        }
        Instantiate(spawnobject);
        float den = Random.Range(1,4);
        if(den == p2.den && den == 4){
            den = den - 1;
        }else if(den == p2.den){
            den = den + 1;
        }
        switch(den){
            case 1:
            sphereRenderer.material.SetColor("_Color", Color.blue);
            break;
            case 2:
            sphereRenderer.material.SetColor("_Color", Color.green);
            break;
            case 3:
            sphereRenderer.material.SetColor("_Color", Color.red);
            break;
            case 4:
            sphereRenderer.material.SetColor("_Color", Color.yellow);
            break;
        }
        Instantiate(spawnobject);
        float den = Random.Range(1,4);
        if(den == p2.den && den == 4){
            den = den - 1;
        }else if(den == p2.den){
            den = den + 1;
        }
        switch(den){
            case 1:
            sphereRenderer.material.SetColor("_Color", Color.blue);
            break;
            case 2:
            sphereRenderer.material.SetColor("_Color", Color.green);
            break;
            case 3:
            sphereRenderer.material.SetColor("_Color", Color.red);
            break;
            case 4:
            sphereRenderer.material.SetColor("_Color", Color.yellow);
            break;
        }
        Instantiate(spawnobject);
        float den = Random.Range(1,4);
        if(den == p2.den && den == 4){
            den = den - 1;
        }else if(den == p2.den){
            den = den + 1;
        }
        switch(den){
            case 1:
            sphereRenderer.material.SetColor("_Color", Color.blue);
            break;
            case 2:
            sphereRenderer.material.SetColor("_Color", Color.green);
            break;
            case 3:
            sphereRenderer.material.SetColor("_Color", Color.red);
            break;
            case 4:
            sphereRenderer.material.SetColor("_Color", Color.yellow);
            break;
        }
        Instantiate(spawnobject);
        Destroy(gameObject);
    }

    void Update()
    {
        if(p2.points == 5f){
            win = win + 1f;
            
        }
    }
    
}
