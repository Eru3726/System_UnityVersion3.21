using System;
using UnityEngine;

//create���琶���ł���悤�ɂ���
[Serializable]
[CreateAssetMenu(fileName = "Enemy", menuName = "DataBase/CreateEnemy")]
public class Enemy : ScriptableObject
{
    public Type enemyType;              //���
    public String enemyName;            //���O
    public Sprite enemySprite;          //�摜
    public int enemyMaxHp;              //�̗�
    public int enemyOffensivePower;     //�U����
    public int enemyDefensePower;       //�h���
    public float enemySpeed;            //���x

    /// <summary>
    /// �L�����̗�
    /// </summary>
    public enum Type
    {
        //�L�����𑝂₵�����ꍇ�͂����ɖ��O��ǉ�����
        Slime,
        Zombie,
        Bat,
    }

    /// <summary>
    /// �ϐ�����
    /// </summary>
    /// <param name="enemy"></param>
    public Enemy(Enemy enemy)
    {
        //�ϐ��𑝂₵���ꍇ�͂����ő���ł���悤�ɂ���
        this.enemyType = enemy.enemyType;
        this.enemyName = enemy.enemyName;
        this.enemySprite = enemy.enemySprite;
        this.enemyMaxHp = enemy.enemyMaxHp;
        this.enemyOffensivePower = enemy.enemyOffensivePower;
        this.enemyDefensePower = enemy.enemyDefensePower;
        this.enemySpeed = enemy.enemySpeed;
    }
}