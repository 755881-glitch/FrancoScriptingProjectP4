using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class DoWhileLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //declaring a bullion variable to use in my whhile loop
        bool shouldContinue = false;

        //my do while loop is going to check is the boolean vaeriable is true and if it is, it will print a message
        do
        {
            print("Hello World!!!");
        }
        while (shouldContinue == true);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
