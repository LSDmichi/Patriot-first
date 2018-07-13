using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.IO;
                 
public struct Item
{
    string item_name; //アイテムの名前
    string item_description; //アイテムの詳細
    int item_effect; //アイテムの効果
    uint item_value; //アイテムの効果値
    int item_type; //カードのタイプ(資源だったり、効果カード、判例カード)
    uint item_price; // 販売時の価格
    Texture item_image; //アイテムの画像

    public Item(string name, string disp, int eff, uint val, int type, uint price, Texture img){
        this.item_name = name;
        this.item_description = disp;
        this.item_effect = eff;
        this.item_value = val;
        this.item_type = type;
        this.item_price = price;
        this.item_image = img;
    }

    public Item ItemDetail(int id){
        Item item = new Item();
        if (id == 0000001) { Item card = Food(); }
        else if (id == 0000002) { Item card = Wood(); }
        else if (id == 0000003) { Item card = Iron(); }
        else if (id == 0000004) { Item card = Gold(); }
        else if (id == 0000005) { Item card = Oil();  }

        if (card == null )
    }

    public List<Item> InitialUserItem(List<int> item_id)
    {
        List<Item> ItemList = new List<Item>();
        foreach (int id in item_id)
        {
            ItemList.Add(new ItemDetail(id));
        }

        return ItemList;
    }

    private Item Food(){
        string name = "食料";
        string disp = "消費カードです";
        int eff = 0;
        uint val = 0;
        int type = 0;
        uint price = 500;
        Texture img = Resources.Load("card/texture/food") as Texture;

        Item data = new Item(name, disp, eff, val, type, price, img);
        return data;
    }

}