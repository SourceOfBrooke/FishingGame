using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject[] fruits = new GameObject[4];


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 4; i++)
        {
            Instantiate(fruits[i]);


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
