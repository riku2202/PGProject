using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator animator;
    [SerializeField] float jumpForce = 5f;
    private bool isGrounded;
    private Rigidbody rb;
    private float speedx;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //�܂������ɐi��
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, 0.0f, Time.deltaTime);
        }
        //���ɐi��
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, 0.0f, -Time.deltaTime);
        }
        //�E
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Time.deltaTime, 0.0f, 0.0f);
        }
        //��
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Time.deltaTime, 0.0f, 0.0f);
        }
        this.animator.speed = speedx / 2.0f;
    }
}