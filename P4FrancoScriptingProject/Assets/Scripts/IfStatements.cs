using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class IfStatements : MonoBehaviour
{
    //Creating the variables for my script
    int cupsInTheSink = 4;
    
    //Creating the variables for my script
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        //my while loop is ging to check if there are cups in the sink and if there are, it will wash them
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've Washed a cup!");
            cupsInTheSink--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TempuratureTest();
        }
        coffeeTemperature -= Time.deltaTime * 5f;
    }


    void TempuratureTest()
    {
        // If the coffee's tempurature is greater than the hottest drinking tempurature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ...do this.
            print("Coffee is to hot.");
        }
        // If it isn't, but the coffee tempurature is less than the coldest drinking tempurature...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ... do this...
            print("Coffee is just right.");
        }
    } 
}
