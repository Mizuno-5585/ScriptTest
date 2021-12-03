using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 24, 7, 98, 35, 58 };

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        for(int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        Boss boss = new Boss();

        for (int i = 0; i < 11; i ++)
        {
            boss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class Boss
    {
        private int mp = 53;   //マジックポイント

        //魔法攻撃用の関数
        public void Magic()
        {
            if (mp >= 5)
            {
                mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            }else
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
        }
    }
}
