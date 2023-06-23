using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector2 inputVec;

    Rigidbody2D rigid;
    Animator anim;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {
        Vector2 nectVec = inputVec.normalized * GameManager.instance.speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nectVec);
    }

    void LateUpdate() {
        anim.SetFloat("Speed", inputVec.magnitude);
    }
}
