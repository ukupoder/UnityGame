using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour {

    public Rigidbody2D rb;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(3, rb.velocity.y);
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        if (Input.GetMouseButtonDown(0) && onGround)
        {

            rb.velocity = new Vector2(rb.velocity.x, 5);
        }

        //Debug.Log(rb.transform.position.y);

        if (rb.transform.rotation.eulerAngles.z < 45 || rb.transform.rotation.eulerAngles.z > 215 || rb.transform.position.y > -10) {
  
        }
        else
        {
            SceneManager.LoadScene("Start");
        }

    }
}
