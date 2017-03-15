using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NekoController : MonoBehaviour
{
    public bool grounded = true;
    public float jumpPower = 1;
    private Rigidbody2D myRigibody;
    public float NekoJumpForce = 400f;
    // Use this for initialization
   

    void Start()
    {
        myRigibody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myRigibody.AddForce(transform.up * NekoJumpForce);
        }

        
//   if(!grounded && myRigibody.velocity.y == 0)
//    {
//
//   }
//   if(Input.touchCount == 1 && grounded == true)
//    {
//       myRigibody.AddForce(transform.up * NekoJumpForce);
//      grounded = false;
// }
    }
}
   
