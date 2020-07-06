using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed=1f;
    [SerializeField]
    private float jumpValue=2f;

    private Rigidbody2D rigidbody;
    private Animator animator;

    public GameObject dieEffect;
    public Text score;
    public GameObject itemEffect;

    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        Jump();
    }

    private void Walk()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }
    
    private void Jump()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpValue);
            animator.SetBool("Jump", true);
        }
        else
        {
            animator.SetBool("Jump", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "crystal")
        {
            Destroy(collider.gameObject);
        }else if (collider.gameObject.tag == "spike")
        {
            Destroy(this.gameObject);
        }else if (collider.gameObject.tag == "portal")
        {

        }
    }
 
}
