 using UnityEngine;
 using System.Collections;
 
 public class joystickrotaatio : MonoBehaviour {
 
    //public Transform target;
    public float rotationSpeed = 4f;
    public float joystickDeadzone = 0.6f;
    private Rigidbody2D body;
    float horizontal;
    float vertical;
    float xAxis;
    float yAxis;
    public float juoksunopeus = 20.0f;
     
 
    void Start () 
    {
        body = GetComponent<Rigidbody2D>(); 
        Cursor.visible = false;
    }
     
    void Update () {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical"); 
        body.velocity = new Vector2(0,0);
        body.angularVelocity = 0f;
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical"); 
        //mousePos = new Vector3(Input.GetAxisRaw("testi1"), Input.GetAxisRaw("testi2"), 10);
        //mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        // Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
        //lookPos = lookPos - transform.position;
        // float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        // this.transform.Rotate(new Vector3(0, 0, rotaatiokerroin));
        //this.transform.position = target.position;
 
        if (Mathf.Abs(Input.GetAxis("testi1")) >= joystickDeadzone || Mathf.Abs(Input.GetAxis("testi2")) >= joystickDeadzone)
        {
            xAxis = Input.GetAxis("testi2");
            yAxis = Input.GetAxis("testi1");
            float joystickAngle = Mathf.Atan2(xAxis, yAxis) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0,0,joystickAngle), Time.deltaTime * rotationSpeed);
        }
    }

    private void FixedUpdate()
    {  
        body.velocity = new Vector2(horizontal * juoksunopeus, vertical * juoksunopeus);
    }
 }
