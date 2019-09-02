using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class start_inactive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
