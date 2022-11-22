using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float acceleration = 2500f;
    Rigidbody rb;
    public Player2 p2;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
        
        
    }
    private void OnMouseDown(){
        Debug.Log(p2.points);
        p2.points = p2.points + 1;
        Destroy(gameObject);
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision){
        float rl = Random.Range(-100f,100f);
        switch(collision.gameObject.tag){
            case "c_obj":
            Debug.Log("collision detected" + rl);
            rb.AddForce(Vector3.up * acceleration);
            if(rl > 0){
            rb.AddForce(Vector3.left * acceleration/4);
            Debug.Log("left");
        }else{
            rb.AddForce(Vector3.right * acceleration/4);
            Debug.Log("right");
            }
            break;
            case "c_obj_a":
            Debug.Log("collision detected" + rl);
            rb.AddForce(Vector3.down * acceleration);
            if(rl > 0){
            rb.AddForce(Vector3.left * acceleration/4);
            Debug.Log("left");
        }else{
            rb.AddForce(Vector3.right * acceleration/4);
            Debug.Log("right");
            }
            break;
            case "c_obj_b":
            Debug.Log("collision detected" + rl);
            rb.AddForce(Vector3.right * acceleration);
            if(rl > 0){
            rb.AddForce(Vector3.up * acceleration/4);
            Debug.Log("up");
        }else{
            rb.AddForce(Vector3.down * acceleration/4);
            Debug.Log("down");
            }
            break;
            case "c_obj_c":
            Debug.Log("collision detected" + rl);
            rb.AddForce(Vector3.left * acceleration);
            if(rl > 0){
            rb.AddForce(Vector3.up * acceleration/4);
            Debug.Log("up");
        }else{
            rb.AddForce(Vector3.down * acceleration/4);
            Debug.Log("down");
            }
            break;
        }
        
        
        }
    }

// Make a code where if they touch each other, they will instantiate and one of them will destroy 