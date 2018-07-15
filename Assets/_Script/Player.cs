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

    public Player()
    {
        PlayerPrefs.GetString
    }

    public Player PlayerSpec(string name, int job, int profile, List<Item> items)
    {
        user_name = name;
        uint base_public_money = 100000;
        uint base_private_money = 50000;
        Job job_data = new Job();
        Job user_job = job_data.JobDetail(job, base_public_money, base_private_money);
        Profile profile_data = new Profile();
        Profile user_profile = profile_data.ProfileDetail(profile);
        user_public_money = base_public_money + user_profile.additional_public_money_from_profile + user_job.additional_public_money_from_job;
        user_private_money = base_private_money + user_profile.additional_private_money_from_profile + user_job.additional_private_money_from_job;
        user_profile_name = user_profile.profile_name;
        user_item = items.AddRange(user_profile.additional_item_list_from_profile);
    }
}
