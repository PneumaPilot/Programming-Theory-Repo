using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LiturgyController : MonoBehaviour
{
    private Church chosenChurch;
    public TextMeshProUGUI SimulationText;
    public TextMeshProUGUI ChosenDenominationText;
    private MenuController menuController;

    private void Start()
    {
        menuController = GameObject.Find("MenuController").GetComponent<MenuController>();
        chosenChurch = menuController.ChosenChurch;
        ChosenDenominationText.text = chosenChurch.DenominationName + " Denomination Chosen";
    }

    public void DisplayPrayer()
    {
        SimulationText.text = chosenChurch.Pray();
    }

    public void DisplaySing()
    {
        SimulationText.text = chosenChurch.Sing();
    }

    public void DisplayBaptize()
    {
        SimulationText.text = chosenChurch.Baptize(3);
    }

    public void DisplayPreach()
    {
        SimulationText.text = chosenChurch.Preach();
    }

    public void DisplayCommune()
    {
        SimulationText.text = chosenChurch.Communion();
    }

    public void ResetDenomination()
    {
        SceneManager.LoadScene(0);
    }
}
