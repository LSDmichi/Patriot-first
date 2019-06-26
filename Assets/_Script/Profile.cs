using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Profile
{
    public string profile_name;
    string profile_disp;
    string profile_effect;
    string profile_effect_discription;
    int profile_type;
    public uint additional_public_money_from_profile;
    public uint additional_private_money_from_profile;
    public List<Item> additional_item_list_from_profile;

    public Profile ProfileSpec (string name, string disp, string eff, string eff_disp, int type, uint add_pub_mny, uint add_pri_mny, List<Item> add_item_list) {
        Profile user_profile = new Profile();
        user_profile.profile_name = name;
        user_profile.profile_disp = disp;
        user_profile.profile_effect = eff;
        user_profile.profile_effect_discription = eff_disp;
        user_profile.profile_type = type;
        user_profile.additional_public_money_from_profile = add_pub_mny;
        user_profile.additional_private_money_from_profile = add_pri_mny;
        user_profile.additional_item_list_from_profile = add_item_list;

        return user_profile;
    }

    public Profile ProfileDetail(int id)
    {
        Profile profile = new Profile();
        if (id == 001) { profile = ABE(); }
        else if (id == 002) { profile = TRUMP(); }
        else if (id == 003) { profile = MELCEL(); }
        else if (id == 004) { profile = TRUDO(); }
        else { profile = Empty(); }

        return profile;
    }




    // ここからプロファイルデータ
    private Profile ABE()
    {
        string name = "安倍 晋三";
        string disp = "安倍 晋三さんです、日本の首相です";
        string eff = "";
        string eff_disp = "";
        int type = 0;
        uint add_pub_mny = 0;
        uint add_pri_mny = 0;
        Item item = new Item();
        List<int> item_id = new List<int> { 1, 4, 5 };
        List<Item> add_item_list = item.MultiUserItem(item_id);

        Profile data = new Profile();
        data = data.ProfileSpec(name, disp, eff, eff_disp, type, add_pub_mny, add_pri_mny, add_item_list);
        return data;
    }

    private Profile TRUMP()
    {
        string name = "ドナルド トランプ";
        string disp = "ドナルド トランプさんです、アメリカの大統領です";
        string eff = "";
        string eff_disp = "";
        int type = 0;
        uint add_pub_mny = 0;
        uint add_pri_mny = 0;
        Item item = new Item();
        List<int> item_id = new List<int> { 1, 4, 5 };
        List<Item> add_item_list = item.MultiUserItem(item_id);

        Profile data = new Profile();
        data = data.ProfileSpec(name, disp, eff, eff_disp, type, add_pub_mny, add_pri_mny, add_item_list);
        return data;
    }

    private Profile MELCEL()
    {
        string name = "アンゲラ メルケル";
        string disp = "アンゲラ メルケルさんです、ドイツの首相です";
        string eff = "";
        string eff_disp = "";
        int type = 0;
        uint add_pub_mny = 0;
        uint add_pri_mny = 0;
        Item item = new Item();
        List<int> item_id = new List<int> { 1, 4, 5 };
        List<Item> add_item_list = item.MultiUserItem(item_id);

        Profile data = new Profile();
        data = data.ProfileSpec(name, disp, eff, eff_disp, type, add_pub_mny, add_pri_mny, add_item_list);
        return data;
    }

    private Profile TRUDO()
    {
        string name = "ジャスティン トルドー";
        string disp = "ジャスティン トルドーさんです、カナダの首相です";
        string eff = "";
        string eff_disp = "";
        int type = 0;
        uint add_pub_mny = 0;
        uint add_pri_mny = 0;
        Item item = new Item();
        List<int> item_id = new List<int> { 1, 4, 5 };
        List<Item> add_item_list = item.MultiUserItem(item_id);

        Profile data = new Profile();
        data = data.ProfileSpec(name, disp, eff, eff_disp, type, add_pub_mny, add_pri_mny, add_item_list);
        return data;
    }

    private Profile Empty()
    {
        string name = "空";
        string disp = "不整合データです";
        string eff = "";
        string eff_disp = "";
        int type = 0;
        uint add_pub_mny = 0;
        uint add_pri_mny = 0;
        Item item = new Item();
        List<int> item_id = new List<int> {};
        List<Item> add_item_list = item.MultiUserItem(item_id);

        Profile data = new Profile();
        data = data.ProfileSpec(name, disp, eff, eff_disp, type, add_pub_mny, add_pri_mny, add_item_list);
        return data;
    }
}
