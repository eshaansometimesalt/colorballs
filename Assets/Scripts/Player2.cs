using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public Transform spawnobject;
    public float points = 0f;
    
    
    void Start()
    {
        
        var sphereRenderer = spawnobject.GetComponent<Renderer>();
        
        
        public float den = Random.Range(1,4);
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
        Instantiate(spawnobject);
        Instantiate(spawnobject);
        Instantiate(spawnobject);
        Instantiate(spawnobject);
        Destroy(gameObject);
    }
}
