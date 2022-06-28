using UnityEngine;

public class Variables : MonoBehaviour
{
    //Full line comment
    /*Mid line comment*/
    /*
     Multiple
     Line
     Comment
     */

    void Start()
    {
       // int = egész számok
        int myFirstVariable; //Declaration
        myFirstVariable = 5; //Definition

        Debug.Log(myFirstVariable);
        
        myFirstVariable = 7; // Set new value
        Debug.Log(myFirstVariable);

       // int a, b, c; //Add muiltiple variables in one line
       
        int secondVariable = 3; //Declare and Define in one line
        Debug.Log(secondVariable);
       
        int x = 3, y = 7, Z = -1; //Multiple declareation and Definition in one line
      
        y = 22; //Always displays current value (22 not 7)

        int summa = x + y + Z;
        Debug.Log(summa);

        int product = x * y * Z;
        Debug.Log(product);

        int dif = x - y;
        Debug.Log(dif);

        int rate = x / y; //Result could be a problem because of int
        Debug.Log(rate);

        int negated = -x;
        Debug.Log(negated);

        int modulo = x % y;
        Debug.Log(modulo);  //Look up modulo in math

    }

}
