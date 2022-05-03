using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboAttack : MonoBehaviour
{
    public Animator playerAnim;
    private bool comboPossible;
    private int comboStep;

    public void Attack()
    {
        if (comboStep == 0)
        {
            playerAnim.Play("AttackA");
            comboStep = 1;
            return;
        }

        if (comboStep != 0)
        {
            if (comboPossible)
            {
                comboPossible = false;
                comboStep += 1;
            }
        }
    }

    public void ComboPossible()
    {
        comboPossible = true;
    }

    public void Combo()
    {
        if (comboStep == 2)
            playerAnim.Play("AttackB");
        if (comboStep == 3)
            playerAnim.Play("AttackC");
    }

    public void ComboReset()
    {
        comboPossible = false;
        comboStep = 0;
    }
}
