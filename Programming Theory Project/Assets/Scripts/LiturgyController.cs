using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LiturgyController : MonoBehaviour
{
    private Church chosenChurch;

    // Start is called before the first frame update
    void Awake()
    {
        MenuController menuController = GameObject.Find("MenuController").GetComponent<MenuController>();
        chosenChurch = menuController.ChosenChurch;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetDenomination()
    {
        SceneManager.LoadScene(0);
    }
}
