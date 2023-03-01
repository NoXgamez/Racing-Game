using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    void Start()
    {
        GameObject foundObject = GameObject.FindGameObjectWithTag("GameController");

        if(foundObject != null)
        {
            GameManager manager = foundObject.GetComponent<GameManager>();
            SpriteRenderer renderer = GetComponent<SpriteRenderer>();

            renderer.sprite = manager.selectedCar;
        }
    }
}
