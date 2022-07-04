using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTra : MonoBehaviour
{
   public GameObject target;
    public Vector3 distance;
    void Start()
    {
        
    }

    
    void Update()
    {

    }
    private void LateUpdate()
    {
    this.transform.position=Vector3.Lerp(this.transform.position, target.transform.position+distance, Time.deltaTime);
    }
}
