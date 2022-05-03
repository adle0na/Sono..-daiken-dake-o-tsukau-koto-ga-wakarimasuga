using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 메모리풀
// 동적할당을 할때 시간이 많이 걸리기 때문에 미리(로딩씬) 처리하여 게임 실행 도중에 급격한 프레임드랍 발생 방지

// 구현방식
// 한번에 대량으로 메모리 할당

public class MemoryPool : MonoBehaviour
{
    private int currentSize = 0;
    private Queue<GameObject> pool = null;

    public int defaultPoolSize = 8;
    public GameObject objPrefab = null;
    public Transform parent = null;

    private static MemoryPool instance = null;

    public static MemoryPool Inst
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            
        }
    }
}
