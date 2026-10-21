using UnityEngine;
using System.Collections;

public class VariblesAndFunctionsScript : MonoBehaviour
{
    // This is a variable
    int myInt = 36;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myInt);
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }


    // this is a function
    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}