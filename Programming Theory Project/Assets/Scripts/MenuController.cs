using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Church ChosenChurch;

    public void SelectDenomination(int denomination)
    {
        Church selectedChurch;
        switch (denomination){
            case 0:
                selectedChurch = new Baptist();
                ChosenChurch = selectedChurch;
                break;
            case 1:
                selectedChurch = new Presbyterian();
                ChosenChurch = selectedChurch;
                break;
            case 2:
                selectedChurch = new Catholic();
                ChosenChurch = selectedChurch;
                break;
            case 3:
                selectedChurch = new Charismatic();
                ChosenChurch = selectedChurch;
                break;
        }
        DontDestroyOnLoad(this.gameObject);

        SceneManager.LoadScene(1);
    }
}
