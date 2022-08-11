 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Player player;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        OnMove();

        OnJump();
    }

    void OnMove()
    {
        if(player.movement.sqrMagnitude > 0)
        {
            anim.SetInteger("transition", 1);
        }
        else
        {
            anim.SetInteger("transition", 0);
        }
    }

    void OnJump()
    {
       if(player.isJumping)
       {
           anim.SetInteger("transition", 2);
       } 
    }
}
