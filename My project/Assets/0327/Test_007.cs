using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    // Start is called before the first frame update
    void SayHello()
    {
        Debug.Log("Hello"); 
          
    }
    void CallNeme(string name)
    {
        Debug.Log("Hello"+ name);

    }

    int Add(int a , int b)
    {

        int C = a + b;
        return C;
    
    }

        // Update is called once per frame
        void Update()
        {
        SayHello();
        SayHello();
        CallNeme("TPM");
        CallNeme("SAM");
         }
}
