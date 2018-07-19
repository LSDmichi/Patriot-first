using System.Collections;
using System.Collections.Generic;
using UnityEngine;
                 
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
        Item card = new Item();
        if (id == 0000001) { card = Food(); }
        else if (id == 0000002) { card = Wood(); }
        else if (id == 0000003) { card = Iron(); }
        else if (id == 0000004) { card = Gold(); }
        else if (id == 0000005) { card = Oil(); }
        else {card = Empty();}

        return card;
    }

    public List<Item> MultiUserItem(List<int> item_id)
    {
        List<Item> ItemList = new List<Item>();
        foreach (int id in item_id)
        {
            Item item = new Item();
            Item data = item.ItemDetail(id);
            ItemList.Add(data);
        }

        return ItemList;
    }

    public IEnumerable<Item> AddRange(List<Item> item1, List<Item> item2)
    {
        foreach (Item i in item1)
            yield return i;
        foreach (Item i in item2)
            yield return i;
    }

    // ここからカードデータ
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

    private Item Wood()
    {
        string name = "木";
        string disp = "消費カードです";
        int eff = 0;
        uint val = 0;
        int type = 0;
        uint price = 500;
        Texture img = Resources.Load("card/texture/wood") as Texture;

        Item data = new Item(name, disp, eff, val, type, price, img);
        return data;
    }

    private Item Iron()
    {
        string name = "鉄";
        string disp = "消費カードです";
        int eff = 0;
        uint val = 0;
        int type = 0;
        uint price = 500;
        Texture img = Resources.Load("card/texture/iron") as Texture;

        Item data = new Item(name, disp, eff, val, type, price, img);
        return data;
    }

    private Item Gold()
    {
        string name = "金";
        string disp = "消費カードです";
        int eff = 0;
        uint val = 0;
        int type = 0;
        uint price = 500;
        Texture img = Resources.Load("card/texture/gold") as Texture;

        Item data = new Item(name, disp, eff, val, type, price, img);
        return data;
    }

    private Item Oil()
    {
        string name = "原油";
        string disp = "消費カードです";
        int eff = 0;
        uint val = 0;
        int type = 0;
        uint price = 500;
        Texture img = Resources.Load("card/texture/oil") as Texture;

        Item data = new Item(name, disp, eff, val, type, price, img);
        return data;
    }

    private Item Empty()
    {
        string name = "空";
        string disp = "存在しないアイテムです";
        int eff = 0;
        uint val = 0;
        int type = 0;
        uint price = 500;
        Texture img = Resources.Load("card/texture/oil") as Texture;

        Item data = new Item(name, disp, eff, val, type, price, img);
        return data;
    }
}