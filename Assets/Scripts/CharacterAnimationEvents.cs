using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationEvents : MonoBehaviour
{
    Character character;
    public Character pers;

    void Start()
    {
        character = GetComponentInParent<Character>();
    }

    void ShootEnd()
    {
        character.SetState(Character.State.Idle);
    }

    void AttackEnd()
    {
        character.SetState(Character.State.RunningFromEnemy);
        
    }
    void Deadpers()
    {
        pers.SetState(Character.State.Dead);
    }

}
