using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ans_check : MonoBehaviour
{
    public static bool clicked = false;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        var name = transform.name;

        if (name == "ans1" && Math_Engine.correct_nr == 1){
            clicked = true;
            Math_Engine.correct_nr = 0;
        }
        if(name == "ans2" && Math_Engine.correct_nr == 2){
            clicked = true;
            Math_Engine.correct_nr = 0;
        }
        if (name == "ans3" && Math_Engine.correct_nr == 3){
            clicked = true;
            Math_Engine.correct_nr = 0;
        }


    }
}
