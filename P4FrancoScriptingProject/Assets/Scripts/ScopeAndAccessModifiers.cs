using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    //adding a public variable
    public int alpha = 5;
    
    //adding a private variable
    private int beta = 0;
    private int gamma = 5;
    
    //add access to another class
    private AnotherClass myOtherClass;

    // Start is called before the first frame update
    void Start()
    {
        //change the starting value of alpha
        alpha = 29;

        //i can change or access another class
        myOtherClass = new AnotherClass();

        //i am going to use the method in another class
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }

    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
