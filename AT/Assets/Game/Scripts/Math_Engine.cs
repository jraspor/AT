using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math_Engine : MonoBehaviour
{
    public SpriteRenderer num1;
    public SpriteRenderer num2;
    public SpriteRenderer equ1;
    public SpriteRenderer equ2;
    public SpriteRenderer ans1;
    public SpriteRenderer ans2;
    public SpriteRenderer ans3;

    public GameObject ans1_object;
    public GameObject ans2_object;
    public GameObject ans3_object;

    private int n1;
    private int n2;
    private int ans;
    private int fake1;
    private int fake2;

    public Sprite zero;
    public Sprite one;
    public Sprite two;
    public Sprite tree;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    public Sprite seven;
    public Sprite eight;
    public Sprite nine;
    public Sprite ten;
    public Sprite eleven;
    public Sprite twelve;
    public Sprite thirteen;
    public Sprite fourteen;
    public Sprite fifteen;
    public Sprite sixteen;
    public Sprite seventeen;
    public Sprite eighteen;
       

    void give_num(SpriteRenderer number_object, int count) {

        if (count == 0) number_object.sprite = zero;
        if (count == 1) number_object.sprite = one;
        if (count == 2) number_object.sprite = two;
        if (count == 3) number_object.sprite = tree;
        if (count == 4) number_object.sprite = four;
        if (count == 5) number_object.sprite = five;
        if (count == 6) number_object.sprite = six;
        if (count == 7) number_object.sprite = seven;
        if (count == 8) number_object.sprite = eight;
        if (count == 9) number_object.sprite = nine;
        if (count == 10) number_object.sprite = ten;
        if (count == 11) number_object.sprite = eleven;
        if (count == 12) number_object.sprite = twelve;
        if (count == 13) number_object.sprite = thirteen;
        if (count == 14) number_object.sprite = fourteen;
        if (count == 15) number_object.sprite = fifteen;
        if (count == 16) number_object.sprite = sixteen;
        if (count == 17) number_object.sprite = seventeen;
        if (count == 18) number_object.sprite = eighteen;
        
    }

    void update_game_numbers() {

        n1 = Random.Range(0, 10);
        n2 = Random.Range(0, 10);
        ans = n1 + n2;

        fake1 = Random.Range(0, 19);
        fake2 = Random.Range(0, 19);

        while (fake1 == fake2 || fake1 == ans || fake2 == ans)
        {
            fake1 = Random.Range(0, 19);
            fake2 = Random.Range(0, 19);
        }

        give_num(num1, n1);
        give_num(num2, n2);

        //treba randomizirat odgovore, tocno je uvijek u sredini
        give_num(ans1, fake1);
        give_num(ans2, ans);
        give_num(ans3, fake2);

    }

    // Start is called before the first frame update
    void Start()
    {
        update_game_numbers();
    }

    // Update is called once per frame
    void Update(){

        if (ans_check.clicked == true){
            
            update_game_numbers();
        }
        
    }
}
