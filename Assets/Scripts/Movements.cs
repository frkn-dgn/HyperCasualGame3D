using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    [SerializeField]
    private float ForwardSpeed;
    [SerializeField]
    private float RightLeftSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizantalAxis=Input.GetAxis("Horizontal") * RightLeftSpeed * Time.deltaTime;
        this.transform.Translate(horizantalAxis,0,ForwardSpeed * Time.deltaTime);

    }
}
