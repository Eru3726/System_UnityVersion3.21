using System.Collections.Generic;
using UnityEngine;

//create���琶���ł���悤�ɂ���
[CreateAssetMenu(fileName = "DataBase", menuName = "DataBase/CreateDataBase")]
public class DataBase : ScriptableObject
{
    //���X�g�̍쐬
    public List<Enemy> enemys = new List<Enemy>();
    public List<Item> items = new List<Item>();
}
