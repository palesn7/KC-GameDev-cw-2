using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{string hero_name = "crash";
int hero_age = 12;
int hero_height = 155+5;
string hero_superpower = "flying";
string villain_name = "momo";
int villain_age = 15; 
float  villain_height = 170.2f;
string villain_superpower = "laser";

    // Start is called before the first frame update
    void Start()
    {
        int ageDifference = villain_age - hero_age;
        print(" Iam a hero "  + " my name is " + hero_name + " my age is " + hero_age + " iam too short " + " my height is " + hero_height + " I have a good ability " + " my power is " + hero_superpower);
        print(" HA HA HA " + " Iam a villain " + " my name is " + villain_name + " my age is " + villain_age + " my height is " + villain_height + " my super power is destroyer " + " it is " + villain_superpower);
    print(" The age difference is " + ageDifference);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
