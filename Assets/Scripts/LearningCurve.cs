using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

    // (CH2)
    public int Age = 21;
    public float ExactAge = 21.375f;
    public string Name = "Riana";
    public bool isDAVStudent = true;

    // (CH3) Private variable (accessible only within this class)
    private int Height = 173;

    // Start is called before the first frame update
    void Start()
    {

        /* 
        (CH2)This is a multi-line comment.
        Hello, Hi, Hey
        Good for long explanations
        */


        // (CH3) Log variables using concatenation
        Debug.Log("My name is " + Name);
        Debug.Log("I am " + Age + " years old");
        Debug.Log("My exact age is " + ExactAge);

        // (CH3) Log using string interpolation
        Debug.Log($"My height is {Height} cm");

        // (CH3) Using a method and capturing its return value
        int doubleAge = DoubleValue(Age);
        Debug.LogFormat("Double my age is {0}", doubleAge);

        
        // (CH4) Conditional logging
        if(isDAVStudent){
            Debug.Log("I am Davidson College Student");

        } else if (!isDAVStudent){
            Debug.Log("I am not a Davidson College Student");
        }

        // (CH4) Nested if statement logging
        if (Age > 18)
        {
            if (Age < 25)
            {
                Debug.Log("You are a young adult");
            }
        }

        // (CH4) Switch statement
        string day = "Monday";

        switch (day)
        {
            case "Monday":
                Debug.Log("Today is Monday");
                break;
            case "Tuesday":
                Debug.Log("Today is Tuesday");
                break;
            default:
                Debug.Log("It's another day");
                break;
        }

        // (CH4) Collections

        // (CH4) Array of strings
        string[] colors = { "red", "green", "blue" };
        Debug.Log("The second color in the array is: " + colors[1]); // green

        // (CH4) Array of ints
        int[] numbers = { 1, 2, 3, 4, 5 };
        Debug.Log("First number in int array: " + numbers[0]);

        // (CH4) List of strings
        List<string> fruits = new List<string> { "grapes", "oranges", "apples" };
        Debug.Log("Second fruit in the list: " + fruits[1]);

        // (CH4) Dictionary of string keys and int values
        Dictionary<string, int> ages = new Dictionary<string, int>
        {
            { "Robert", 47 },
            { "Rhana", 42 },
            { "Riana", 21 },
            { "Bobby", 15 },
            { "Rylan", 3 },
        };

        // (CH4) Find the youngest person
        string youngestName = "";
        int youngestAge = int.MaxValue;

        foreach (KeyValuePair<string, int> entry in ages)
        {
            if (entry.Value < youngestAge)
            {
                youngestAge = entry.Value;
                youngestName = entry.Key;
            }
        }

        Debug.Log($"The youngest person in my family is {youngestName}, age {youngestAge}");
        
        // (CH4) Loops

        // (CH4) For loop: print a specific index of a List<string>
        for (int i = 0; i < fruits.Count; i++)
        {
            if (i == 2) 
            {
                Debug.Log("For loop, 3rd fruit: " + fruits[i]);
            }
        }

        // (CH4) Foreach loop: print all elements of a List<string>
        foreach (string fruit in fruits)
        {
            Debug.Log("Foreach loop fruit: " + fruit);
        }

        // (CH4) Foreach loop: print all key-value pairs of a Dictionary
        foreach (KeyValuePair<string, int> entry in ages)
        {
            Debug.Log($"Name: {entry.Key}, Age: {entry.Value}");
        }


        // (CH5) Create a Weapon struct first
        Character.Weapon warBow = new Character.Weapon("War Bow", 25);
        // (CH5) Instantiate a Paladin object
        Paladin knight = new Paladin("Lancelot", 35, warBow);
        // (CH5) Print the Paladin's name and weapon
        knight.PrintStatsInfo();

        // (CH5) Main camera reference
        Transform cameraTransform = Camera.main.GetComponent<Transform>();
        Debug.Log($"Main Camera localPosition: {cameraTransform.localPosition}");

        // (CH5) Light reference 
        GameObject lightObject = GameObject.Find("Directional Light");
        if (lightObject != null)
        {
            Transform lightTransform = lightObject.GetComponent<Transform>();
            Debug.Log($"Light localPosition: {lightTransform.localPosition}");
        }
        else
        {
            Debug.Log("Directional Light not found in the scene!");
        }



        
    }


    /// <summary>
    /// CH(3) Doubles the input value and returns it.
    /// Demonstrates method parameters and return types.
    /// </summary>
    /// <param name="value">The integer value to double</param>
    /// <returns>The doubled value</returns>
    int DoubleValue(int value)
    {
        return value * 2;
    }

    

    // Update is called once per frame
    void Update()
    {

     
    }

}