using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello");
    }

    // Update is called once per frame
    void OnMove(InputValue value)
    {
        //Debug.Log("hello world");
       Vector2 dir = value.Get<Vector2>();
       Debug.Log(dir);
       rb.velocity = dir * 10;
    }
}
