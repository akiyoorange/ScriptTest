using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Start()
    {
        //要素数5の配列を初期化
        int[] array = new int[5];

        //配列の各要素に値を代入
        array[0] = 23;
        array[1] = 67;
        array[2] = 43;
        array[3] = 3;
        array[4] = 16;

        //順番に表示
    　　for(int i = 0;i < 5; i++)
        {
            Debug.Log(array[i]);
        }

       //逆順に表示
       for(int i = 4;i > -1; i--)
        {
            Debug.Log(array[i]);
        }

    }
    
    void Update()
    {
        
    }
}
