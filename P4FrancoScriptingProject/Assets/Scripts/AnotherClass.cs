using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    //adding 2 public variable to the class
    public int apples = 5;
    public int bananas = 10;

    //adding 2 private variable to the class
    private int stapler;
    private int sellotape;
    
    // Start is called before the first frame update
    public void FruitMachine (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total; " + answer);
    }

    // Update is called once per frame
    private void OfficeSort (int a, int b)
    {
        int answer;
        answer = a = b;
        Debug.Log("Office Supplies total: " + answer);
    }
}
