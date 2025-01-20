using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    public bool augmentation = true;
    public bool dimunition = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(3, 3, 3);
        Debug.Log("Magnetude : " + transform.localScale.magnitude);
       
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localScale.magnitude >= 8) { augmentation = false; dimunition = true; }
        else if (transform.localScale.magnitude <= 2) {  augmentation = true; dimunition = false; }
        while (augmentation = true)
        {
            var Scale = new Vector3(1, 1, 1);
            transform.localScale += Scale * Time.deltaTime;
        }
        while (dimunition = true) 
        {
            var Scale = new Vector3(1, 1, 1);
            transform.localScale -= Scale * Time.deltaTime;
        }
    }
}
