using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSelectController : MonoBehaviour
{
    GameManager manager;

    void Start()
    {
        GameObject foundObject = GameObject.FindGameObjectWithTag("GameController");

        manager = foundObject.GetComponent<GameManager>();
    }

    public void UpdateSelectedCar(Button selectedButton)
    {
        Image buttonImage = selectedButton.GetComponent<Image>();

        manager.selectedCar = buttonImage.sprite;
        manager.LoadScene("Game");
    }
}
