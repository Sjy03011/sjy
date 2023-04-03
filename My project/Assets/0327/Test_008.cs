using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player
{
    private int hp = 100;
    private int power = 50;
    public void Attack()
    {
        Debug.Log(this.power + "데미지를 입혔다");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "데미지를 입었다");

    }    public int GetHp()
    {
        return this.hp;
    }


}

public class Test_008 : MonoBehaviour
{
    Player player_01 = new Player();
    Player player_02 = new Player();
    public Text player01HP;
    public Text player02HP;

    // Update is called once per frame
    void Start()
    {

        player_01.Attack();
        player_01.Damage(30);

    }
    // Update is called once per frame
    void Update()
    {  //UI를 업데이트에 출력
        player01HP.text = "player 01 Hp :" + player_01.GetHp().ToString();
        player02HP.text = "player 02 Hp :" + player_02.GetHp().ToString();

        if (Input.GetMouseButtonDown(0))
        {
            player_01.Damage(1);
        }

        if (Input.GetMouseButtonDown(0))
        {
            player_02.Damage(1);
        }
    }
}




