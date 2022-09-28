using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isPlayer1;
    public bool isPlayer2;
    public Rigidbody rigid;
    public Transform groundCheck;

    [Header("Stats")]
    public int jumpAmounts = 2;
    public int moveforce;
    public int JumpForce;
    public float groundDistance;
    public LayerMask groundMask;


    int usedJumps = 0;


    // Update is called once per frame
    void Update()
    {
        bool isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isPlayer2 && isPlayer1)
        {
            Debug.LogError("your stupid");
        }

        if (isPlayer1)
        {
            if (Input.GetKey(KeyCode.A))
            {
                rigid.AddForce(new Vector3(0, 0, -moveforce));
            }
            if (Input.GetKey(KeyCode.D))
            {
                rigid.AddForce(new Vector3(0, 0, moveforce));
            }
            if (Input.GetKeyDown(KeyCode.W) && usedJumps < jumpAmounts)
            {
                rigid.AddForce(new Vector3(0, JumpForce, 0));
                usedJumps++;
            }

            if (isGrounded)
            {
                usedJumps = 0;
            }



        }



    }
}
