using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {


        // 要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[] array = { 1, 2, 3, 4, 5 };


        // for文を使い、配列の各要素の値を順番に表示してください
        for (int i = 0; i<array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //for文を使い、配列の各要素の値を逆順に表示してください
        for (int i = array.Length-1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認してください
        Boss lastboss = new Boss();
        for (int i=0; i<11; i++)
        {
            lastboss.Magic();
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}

public class Boss
{
    private int hp = 100; // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // 魔力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 魔法攻撃用の関数
    public void Magic()
    {
        if (mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
            return;
        }

        mp -= 5;

        Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}