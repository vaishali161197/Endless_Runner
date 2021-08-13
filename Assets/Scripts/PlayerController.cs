using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    [SerializeField] float slide = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void stopJump()
    {
        anim.SetBool("isJumping", false);
    }
    void stopMagic()
    {
        anim.SetBool("isMagic", false);
    }
    // Update is called once per frame
    void Update()
    {
        jump();
        Magic();
        turn();
        slideAcross();
    }

    private void Magic()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            anim.SetBool("isMagic", true);
        }
    }

    private void jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isJumping", true);
        }
    }

    private void turn()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.up * 90);
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.up * -90);
        }
    }

    private void slideAcross()
    {
        if(Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-slide * Time.deltaTime, 0f, 0f);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(slide * Time.deltaTime, 0f, 0f);
        }
    }
}
