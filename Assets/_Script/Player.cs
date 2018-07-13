using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Player
{

	string user_name;
    uint user_public_money;
    uint user_private_money;
    int user_job_type;
    string user_profile_name;
    List<Item> user_item;

    public Player(string name, int job, string profile, List<Item> items)
    {
        user_name = name;
        user_public_money = 100000;
        user_private_money = 50000;
        user_job_type = job; // あとでnew処理に変える
        user_profile_name = profile; // あとでnew処理に変える
        user_item = items;

    }
}
