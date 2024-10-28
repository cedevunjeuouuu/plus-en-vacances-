using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class AI : MonoBehaviour
{
    [SerializeField] private GameObject finDuCombat;
    [SerializeField] private FightManager fightManagerReference;
    public enum AIState
    {
        loosing,
        winning, 
    }

    public AIState m_currentAIState = AIState.winning;
        
    public void DetermineState(int hp)
    {
        m_currentAIState = hp < 10 ? AIState.loosing : AIState.winning;
    }
        
    public void ManageAITurn()
    {
        switch (m_currentAIState )
        {
            case AIState.loosing:ManageLoosing(); break;
            case AIState.winning: ManageWinning(); break;
            default: throw new ArgumentOutOfRangeException();
        }   
    }

    public void ManageLoosing()
    {
        var rand = Random.Range(0, 100);
        if (rand> 85)
        {
            RunAway();
            return;
        } 
        
        if(rand > 70)
        {
            Heal();
            return;
        }
     
        Attack();
    }

    public void Attack()
    {
        var random = Random.Range(1, 4);
        switch (random)
        {
            case 1 :
                fightManagerReference.AttackFire();
                break;
            case 2 :
                fightManagerReference.AttackWater();
                break;
            case 3 :
                fightManagerReference.AttackPlant();
                break;
        }
    }
    
    public void Heal()
    {
        
    }
    
    public void RunAway()
    {
        finDuCombat.SetActive(true);
    }
    
    public void ManageWinning()
    {
        Attack();
    }
}