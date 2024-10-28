using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = System.Random;

public class FightManager : MonoBehaviour
{
    [SerializeField]private GameObject text1;
    [SerializeField]private GameObject text2;
    private bool state = true;
    [SerializeField] private PlayerStats Player;
    [SerializeField] private TextMeshProUGUI PlayerGameObject;
    [SerializeField] private PlayerStats otherPlayer;
    [SerializeField] private TextMeshProUGUI otherPlayerGameObject;

    private void Update()
    {
        if (!state)
        {
            Random rdn = new Random() ;
            int random = rdn.Next(1, 4);
            switch (random)
            {
                case 1 :
                    AttackFire();
                    break;
                case 2 :
                    AttackWater();
                    break;
                case 3 :
                    AttackPlant();
                    break;
            }
        }
    }

    private void Start()
    {
        Tour();
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
            
        }
    }
}
