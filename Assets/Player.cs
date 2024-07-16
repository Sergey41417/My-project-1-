using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
public Rigidbody rigidbody;
public int maxSpeed = 5;
public float acceleration = 3.0f;
void Accelerate(Vector3 direction){
    Vector3 horizontalVelocity = rigidbody.velocity;
    
    float currentSpeed = rigidbody.velocity.magnitude;
    rigidbody.AddForce(direction * acceleration, ForceMode.Acceleration);

}
void Update(){
    if (Input.GetKey(KeyCode.D)){
        Accelerate(Vector3.forward);
    }
     if (Input.GetKey(KeyCode.W)){
        Accelerate(Vector3.left);
    }
    if (Input.GetKey(KeyCode.A)){
        Accelerate(Vector3.back);
    }
     if (Input.GetKey(KeyCode.S)){
        Accelerate(Vector3.right);
    }
}
    private void OnTriggerEnter(Collider other){
            if(this.CompareTag("Player") && other.CompareTag("Finish")){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
    }

}


