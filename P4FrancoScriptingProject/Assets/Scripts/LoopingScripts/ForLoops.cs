using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    // Start is called before the first frame update
    int numEnemies = 3;
    void Start()
    {
        
        //my for loop is going to check if there are enemies in the game and if there are, it will print a message
        for (int i = 0;  i < numEnemies; i++)
        {
            Debug.Log("Creating enemeny number: " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
