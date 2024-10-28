using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class FightManager : MonoBehaviour
{
    [SerializeField]private GameObject text1;
    [SerializeField]private GameObject text2;
    private bool state = true;
    [SerializeField] private PlayerStats Player;
    [SerializeField] private TextMeshProUGUI PlayerGameObject;
    [SerializeField] private PlayerStats otherPlayer;
    [SerializeField] private TextMeshProUGUI otherPlayerGameObject;
    [SerializeField] private AI player2;

    private void Start()
    {
        Tour();
    }

    private void Update()
    {
        
    }

    public void changeState()
    {
        if (state)
        {
            state = false;
        }
        else
        {
            state = true;
        }

        Tour();
    }
    void Tour()
    {
        switch (state)
        {
            case true:
                text1.SetActive(true);
                text2.SetActive(false);
                break;
            case false:
                text1.SetActive(false);
                text2.SetActive(true);
                player2.ManageAITurn();
                break;
        }
    }
    public void AttackFire()
    {
        if (state)
        {
            if (otherPlayer.weakness == "fire")
            {
                otherPlayer.healPoints -= 100;
            }
            else if (otherPlayer.strong == "fire")
            {
                otherPlayer.healPoints -= 30;
            }
            else
            {
                otherPlayer.healPoints -= 75;
            }

            otherPlayerGameObject.text = otherPlayer.healPoints + " Pv ";
            state = false;
            Tour();
        }
        else
        {
            if (Player.weakness == "fire")
            {
                Player.healPoints -= 100;
            }
            else if (Player.strong == "fire")
            {
                Player.healPoints -= 30;
            }
            else
            {
                Player.healPoints -= 75;
            }

            PlayerGameObject.text = Player.healPoints + " Pv ";
            state = true;
            Tour();
        }
        
    }

    public void AttackWater()
    {
        if (state)
        {
            if (otherPlayer.weakness == "water")
            {
                otherPlayer.healPoints -= 100;
            }
            else if (otherPlayer.strong == "water")
            {
                otherPlayer.healPoints -= 30;
            }
            else
            {
                otherPlayer.healPoints -= 75;
            }

            otherPlayerGameObject.text = otherPlayer.healPoints + " Pv ";
            state = false;
            Tour();
        }
        else
        {
            if (Player.weakness == "water")
            {
                Player.healPoints -= 100;
            }
            else if (Player.strong == "water")
            {
                Player.healPoints -= 30;
            }
            else
            {
                Player.healPoints -= 75;
            }
            PlayerGameObject.text = Player.healPoints + " Pv ";
            state = true;
            Tour();
        }
        
    }

    public void AttackPlant()
    {
        if (state)
        {
            if (otherPlayer.weakness == "plant")
            {
                otherPlayer.healPoints -= 100;
            }
            else if (otherPlayer.strong == "plant")
            {
                otherPlayer.healPoints -= 30;
            }
            else
            {
                otherPlayer.healPoints -= 75;
            }
            otherPlayerGameObject.text = otherPlayer.healPoints + " Pv ";
            state = false;
            Tour();
        }
        else
        {
            if (Player.weakness == "plant")
            {
                Player.healPoints -= 100;
            }
            else if (Player.strong == "plant")
            {
                Player.healPoints -= 30;
            }
            else
            {
                Player.healPoints -= 75;
            }
            
            PlayerGameObject.text = Player.healPoints + " Pv ";
            state = true;
            Tour();
            
        }
    }
    
}
