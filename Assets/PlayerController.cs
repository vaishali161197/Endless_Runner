using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void stopJump()
    {
        anim.SetBool("isJumping", false);
    }
    // Update is called once per frame
    void Update()
    {
        jump();
    }

    private void jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isJumping", true);
        }
    }
}
