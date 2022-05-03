using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VariableBtn : MonoBehaviour
{
    private PlayerAnimator _playerAnimator;

    public Button atk, dodge, hisatsu; 

    private void Awake()
    {
        _playerAnimator = GetComponent<PlayerAnimator>();
        atk.onClick.AddListener(atkclick);
        dodge.onClick.AddListener(dodgeclick);
        hisatsu.onClick.AddListener(hisatsuclick);
    }

    void atkclick()
    {
        Debug.Log("공격버튼 눌림");
    }

    void dodgeclick()
    {
        Debug.Log("회피버튼 눌림");
    }

    void hisatsuclick()
    {
        Debug.Log("궁극기 버튼 눌림");
    }
}
