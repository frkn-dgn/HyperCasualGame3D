using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picker : MonoBehaviour
{
    GameObject Maincube;
    int height;

    void Start()
    {
        Maincube=GameObject.Find("Cube");
    }

    void Update()
    {
       Maincube.transform.position=new Vector3(transform.position.x,height +1,transform.position.z);
       this.transform.localPosition = new Vector3(0,-height,0);
    }
    public void Heightreduction()
        {
             height--;
        }
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="add" && other.gameObject.GetComponent<collectiblecube>().GetaddedTo()==false)
        {
            height += 1;
             other.gameObject.GetComponent<collectiblecube>().collection();
             other.gameObject.GetComponent<collectiblecube>().IndexSettings(height);
             other.gameObject.transform.parent=Maincube.transform;
        }
    }
}
