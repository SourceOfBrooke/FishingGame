using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject[] fruits = new GameObject[4];


    // Start is called before the first frame update
    void Start()
    {
        int number = Random.Range(0, 30);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            for (int i = 0; i <= 3; i++)
            {
                Instantiate(fruits[i]);


            }
        }
        
    }
}
