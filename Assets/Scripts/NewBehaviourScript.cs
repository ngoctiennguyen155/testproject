using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
     // Start is called before the first frame update

     public float speed;
     private float vertical, horizontal;

     public Animator ani;
     private Quaternion rot;
     void Start()
     {
          //rot = transform.rotation;
          ani.SetBool("isMove", true);
     }

     // Update is called once per frame
     void Update()
     {
          ani.SetFloat("hor", Input.GetAxis("Horizontal"));
          ani.SetFloat("ver", Input.GetAxis("Vertical"));

          //   Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
          //   RaycastHit hit;
          //   if (Physics.Raycast(ray, out hit))
          //   {
          //        transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
          //   }
     }
     void FixedUpdate()
     {

     }
     void OnTriggerEnter(Collider other)
     {
          if (other.CompareTag("wall"))
          {


          }

     }
}
