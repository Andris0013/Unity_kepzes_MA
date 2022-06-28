using UnityEngine;

public class BoolPractice : MonoBehaviour
{
    [SerializeField] bool b1;   //If thicked in Unity that means it true

    // With bool we can set for example if we want to use a setting for a game, like if a bullet has range in the game or no. Of course we have to program all of it just turns it on or off. 

    [SerializeField] int ageOfJohn;
    [SerializeField] int ageOfGreg;

    [SerializeField] bool isJohnOlderThanGreg;
    [SerializeField] bool isJohnAndnGregSameAge;
    [SerializeField] bool isJohnAndnGregNotSameAge;


    void OnValidate()
    {
        isJohnOlderThanGreg = ageOfJohn > ageOfGreg;
        isJohnAndnGregSameAge = ageOfJohn == ageOfGreg;
        isJohnAndnGregNotSameAge = ageOfJohn != ageOfGreg;

        float f1 = 3, f2 = 5;
        bool b2 = f1 >= f2;         //Bigger or equal
        bool b3 = f1 <= f2;         //Smaller or equal

        // Bool az eldöntendõ kérdésekre ad választ. 
        // Bool használható az eldöntendõ kérdések eredményeinek a kapcsolatának a vizsgálására is.
        // Bool tehát nem csak a vagyra használható, hanem az ésre is: b1 && b2 = 


        bool a = true, b = false, c = false;
        int i1 = 3, i2 = 6, i3 = 10;
        string st = "AAA";

        bool aNegated = !a;         // nem (azaz komplementer)
        bool aOrb = a || b;         // vagy
        bool aAndb = a && b;        // és

        bool x = a || b && c;                   // False
        bool y = (i1 > i2) || b;                // False
        bool z = (i2 <= i3) && st == "BBB";     // False
    }

}
