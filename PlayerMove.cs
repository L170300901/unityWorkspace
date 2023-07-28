using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 7f;
    CharacterController cc;

    float gravity = -20f;
    public float yVelocity =0;
    public float jumpPower =10f;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h,0,v);
        dir = dir.normalized;

        dir = Camera.main.transform.TransformDirection(dir);

        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        cc.Move(dir * moveSpeed * Time.deltaTime);

        transform.position += dir * moveSpeed * Time.deltaTime;

        if (Input.GetButtonDown("Jump"));
        {
            yVelocity = jumpPower;
        }

        

        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        cc.Move(dir *moveSpeed * Time.deltaTime);
        
    }
}
