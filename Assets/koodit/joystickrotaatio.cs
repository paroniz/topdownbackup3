 using UnityEngine;
 using System.Collections;
 
 public class joystickrotaatio : MonoBehaviour {
 
     //public Transform target;
     public float rotationSpeed = 4f;
     public float joystickDeadzone = 0.2f;
 
     float xAxis;
     float yAxis;
 
     void Start () {
         
     }
     
     void Update () {
 
         //this.transform.position = target.position;
 
         if (Mathf.Abs(Input.GetAxis("testi1")) >= joystickDeadzone || Mathf.Abs(Input.GetAxis("testi2")) >= joystickDeadzone)
         {
             xAxis = Input.GetAxis("testi2");
             yAxis = Input.GetAxis("testi1");
         }
 
         float joystickAngle = Mathf.Atan2(xAxis, yAxis) * Mathf.Rad2Deg;
 
         transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0,0,joystickAngle), Time.deltaTime * rotationSpeed);
 
     }
 }
