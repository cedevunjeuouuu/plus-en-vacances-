using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]private GameObject menu;
    [SerializeField] private GameObject game;

    private void Start()
    {
        game.SetActive(false);
    }

    public void GameState(int changeState)
    {
        switch (changeState)
        {
            case 1 :
                game.SetActive(false);
                menu.SetActive(true);
                break;
            case 2:
                menu.SetActive(false);
                game.SetActive(true);
                break;
        }
    }
}
