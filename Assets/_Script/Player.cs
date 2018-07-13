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

    public Player(string name, int job, int profile, List<Item> items)
    {
        user_name = name;
        user_job_type = job; // あとでnew処理に変える
        Profile profile_data = new Profile();
        Profile user_profile = profile_data.ProfileDetail(profile);
        uint base_public_money = 100000;
        uint base_private_money = 50000;
        user_public_money = base_public_money + user_profile.additional_public_money;
        user_private_money = base_private_money + user_profile.additional_private_money;
        user_profile_name = user_profile.profile_name;
        user_item = items;

    }
}
