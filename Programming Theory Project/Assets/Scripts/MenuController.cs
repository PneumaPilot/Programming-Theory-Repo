using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Church ChosenChurch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectDenomination(int denomination)
    {
        switch (denomination){
            case 0:
                ChosenChurch = new Baptist();
                break;
            case 1:
                ChosenChurch = new Presbyterian();
                break;
            case 2:
                ChosenChurch = new Catholic();
                break;
            case 3:
                ChosenChurch = new Charismatic();
                break;
        }
        DontDestroyOnLoad(this.gameObject);

        SceneManager.LoadScene(1);
    }
}
