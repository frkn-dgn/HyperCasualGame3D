using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectiblecube : MonoBehaviour
{
   bool addedTo;
   int index;
   public Picker picker;
    void Start()
    {
        addedTo= false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(addedTo == true){
             if(transform.parent != null)
        {
            transform.localPosition = new Vector3 (0,-index,0); 

        }

        }
       
        
    }
     private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "barrier")
        {
        picker.Heightreduction();
        transform.parent = null;
        GetComponent<BoxCollider>().enabled = false;
        other.gameObject.GetComponent<BoxCollider>().enabled= false;

        }
    }
    public bool GetaddedTo()
    {
        return addedTo;
    }
    public void collection()
    {
        addedTo = true;
    }
    public void IndexSettings(int index)
    {
        this.index = index;
    }
}

