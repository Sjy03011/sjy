using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_006 : MonoBehaviour
{
    int[] array = new int[5];
    int[] points = { 83, 99, 52, 93, 15 };


    // Start is called before the first frame update
    void Start()
    {
        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[1] = 15;
        array[1] = 3;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        int sum = 0;

        for (int i = 0; i < points.Length; i++)
        {
            if (points[i] > 90)
            {
                Debug.Log(points[i]);
            }
            sum += points[i];

        }
        int average = sum / points.Length;
        Debug.Log(average);
    }   
      

    // Update is called once per frame
    void Update()
    {
        
    }
}
