using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     // Start is called before the first frame update
     public float speed;
     private float vertical, horizontal;
     public Rigidbody rb;

     void Start()
     {
     }

     // Update is called once per frame
     void Update()
     {
          vertical = Input.GetAxis("Vertical");
          horizontal = Input.GetAxis("Horizontal");
          Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
          RaycastHit hit;
          if (Physics.Raycast(ray, out hit))
          {
               transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
          }
     }
     void FixedUpdate()
     {
          rb.MovePosition(rb.position + new Vector3(horizontal, 0f, vertical) * speed * Time.deltaTime);
          if (Input.GetKeyDown(KeyCode.Space))
          {
               rb.MovePosition(rb.position + new Vector3(0f, 5f, 0f) * speed * Time.deltaTime);
          }
     }
}
