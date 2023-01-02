using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float roatateSpeed;
    void Update()
    {
        transform.Rotate(Vector3.up * roatateSpeed * Time.deltaTime, Space.World);
    }
}
