using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{

    float currentTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime < 0) 
        {
            Destroy(gameObject);
        }


        if (Input.GetKeyDown(KeyCode.E))
        {
            

        }
        
    }
}
