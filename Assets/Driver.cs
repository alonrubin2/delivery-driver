using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]
    float turnSpeed = 250f;

    [SerializeField]
    float moveSpeed = 30f;

    [SerializeField]
    float slowSpeed = 20f;

    [SerializeField]
    float fastSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("drive, Mothafucker!");
    }

    // Update is called once per frame
    void Update()
    {
        float frameRate = Time.deltaTime;
        bool drift = Input.GetAxis("handBreak") > 0;
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * frameRate;
        if (drift)
        {
            turnAmount *= 2;
        }

        float exelaration = Input.GetAxis("Vertical") * moveSpeed * frameRate;
        transform.Rotate(0, 0, -turnAmount);
        transform.Translate(0, exelaration, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            Debug.Log("BOOST");
            moveSpeed = fastSpeed;
        }
    }
}
