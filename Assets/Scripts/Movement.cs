using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float mainThrust = 100f;
    [SerializeField] private float rotationThrust = 1f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(mainThrust * Time.deltaTime * Vector3.up);
        }
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            NewMethod();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(rotationThrust * Time.deltaTime * Vector3.back);
        }
    }

    void NewMethod()
    {
        transform.Rotate(rotationThrust * Time.deltaTime * Vector3.forward);
    }
}
