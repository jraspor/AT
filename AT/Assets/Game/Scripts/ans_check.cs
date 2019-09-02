using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ans_check : MonoBehaviour
{
    public static bool clicked = false;
    // Start is called before the first frame update

    public SpriteRenderer ans1;
    public SpriteRenderer ans2;
    public SpriteRenderer ans3;

    public Sprite smiley;
    public Sprite sadley;

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

        if (name == "ans1" && ans1.sprite != smiley) ans1.sprite = sadley;
        if (name == "ans1" && Math_Engine.correct_nr == 1){
            clicked = true;
            Math_Engine.correct_nr = 0;
            ans1.sprite = smiley;
        }

        if (name == "ans2" && ans2.sprite != smiley) ans2.sprite = sadley;
        if (name == "ans2" && Math_Engine.correct_nr == 2){
            clicked = true;
            Math_Engine.correct_nr = 0;
            ans2.sprite = smiley;
        }

        if (name == "ans3" && ans3.sprite != smiley) ans3.sprite = sadley;
        if (name == "ans3" && Math_Engine.correct_nr == 3){
            clicked = true;
            Math_Engine.correct_nr = 0;
            ans3.sprite = smiley;
        }



    }
}
