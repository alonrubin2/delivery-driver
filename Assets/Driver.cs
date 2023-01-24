using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]
    int turnSpeed = 250;

    [SerializeField]
    int moveSpeed = 30;

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
}
