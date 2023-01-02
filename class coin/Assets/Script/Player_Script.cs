using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{
    public GameManager gameManager;
    public Rigidbody rbody;
    public FixedJoystick fixedJoystick;
    public Vector3 moveDir;
    public float moveSpeed;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") + fixedJoystick.Horizontal;
        float z = Input.GetAxisRaw("Vertical") + fixedJoystick.Vertical;
        moveDir = new Vector3(x, 0, z);
        moveDir.Normalize();
    }

    private void FixedUpdate()
    {
        rbody.MovePosition(rbody.position + moveDir * moveSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Coin>() != null)
        {
            gameManager.Gotcoin();
            Destroy(collision.gameObject);
        }
    }
}
