using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("drive, Mothafucker!");
    }

    // Update is called once per frame
    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal")*turnSpeed;
        float exelaration = Input.GetAxis("Vertical")*moveSpeed;
        transform.Rotate(0,0,-turnAmount);
        transform.Translate(0,exelaration,0);

    }
}
