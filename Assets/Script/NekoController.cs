using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NekoController : MonoBehaviour
{
    public bool grounded = true;
    public float jumpPower = 1;
    private Rigidbody2D myRigibody;
    public float NekoJumpForce = 400f;
    public Text scoreText;
    private int startTime;
    private Collider2D myCollider;
    // Use this for initialization
   

    void Start()
    {
        myRigibody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myRigibody.AddForce(transform.up * NekoJumpForce);
        }

        scoreText.text = ((Time.time - startTime)* 5).ToString("0");
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        
    }
}
   
