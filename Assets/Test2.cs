using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; //体力
    private int power = 25; //攻撃力
    private int mp = 53; //MP

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りHPを減らす
        this.hp -= damage;
    }
    //魔法攻撃用の関数
    public void Magic(int use)
    {
        if (mp >= 5)
        {
           //MPを5消費する
            this.mp -= use;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
           
        }

        else if (mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
        
    }
}

public class Test2 : MonoBehaviour
{ 

    // Start is called before the first frame update
    void Start()
    {
        //Bossクラスの変数を宣言、インスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);



        //魔法用の関数を呼び出す   
        for (int i = 0; i <= 10; i++)
        {
            lastboss.Magic(5);
        }
 
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
