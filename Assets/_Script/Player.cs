using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Player
{
	string user_name;
    uint user_public_money;
    uint user_private_money;
    string user_job_name;
    string user_profile_name;
    List<Item> user_item;


    public Player PlayerSpec(string name, int job, int profile, List<Item> items)
    {
        user_name = name;

        uint base_public_money = 100000;
        uint base_private_money = 50000;

        Job job_data = new Job();
        Job user_job = job_data.JobDetail(job);

        Profile profile_data = new Profile();
        Profile user_profile = profile_data.ProfileDetail(profile);

        user_public_money = base_public_money + user_profile.additional_public_money_from_profile + user_job.additional_public_money_from_job;
        user_private_money = base_private_money + user_profile.additional_private_money_from_profile + user_job.additional_private_money_from_job;

        user_profile_name = user_profile.profile_name;

        //has some problems under this line 
        List<Item> item_list = new List<Item>() { };
        item_list.AddRange(user_profile.additional_item_list_from_profile);
        item_list.AddRange(user_job.addtional_item_list_from_job);

        Player player = new Player();
        player.user_name = name;
        player.user_public_money = user_public_money;
        player.user_private_money = user_private_money;
        player.user_job_name = user_job.job_name;
        player.user_profile_name = user_profile.profile_name;
        player.user_item = user_item;
        
        return player;
    }
}
