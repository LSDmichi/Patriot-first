using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Job
{
    public string job_name;
    public uint additional_public_money_from_job;
    public uint additional_private_money_from_job;
    public List<Item> addtional_item_from_job;

    public Job(string name, uint base_public_money, uint base_private_money, List<Item> addtional_item)
    {
        job_name = name;
        additional_public_money_from_job = base_public_money;
        additional_private_money_from_job = base_private_money;
        addtional_item_from_job = addtional_item;
    }

    public Job JobDetail(int id)
    {
        Job job = new Job();
        if (id == 0000001) { job = Administration(); }
        else if (id == 0000002) { job = Research(); }
        else if (id == 0000003) { job = Stock(); }
        else if (id == 0000004) { job = Military(); }
        else { job = Empty(); }

        return job;
    }

    private Job Administration()
    {
        string name = "内政";
        uint base_public_money = 50000;
        uint base_private_money = 200000;
        List<Item> item = new List<Item> { };
        Job job = new Job(name, base_public_money, base_private_money, item);
        return job;
    }

    private Job Research()
    {
        string name = "研究";
        uint base_public_money = 200000;
        uint base_private_money = 50000;
        List<Item> item = new List<Item> { };
        Job job = new Job(name, base_public_money, base_private_money, item);
        return job;
    }

    private Job Stock()
    {
        string name = "備蓄";
        uint base_public_money = 250000;
        uint base_private_money = 0;
        List<Item> item = new List<Item> { };
        Job job = new Job(name, base_public_money, base_private_money, item);
        return job;
    }

    private Job Military()
    {
        string name = "軍備";
        uint base_public_money = 200000;
        uint base_private_money = 50000;
        List<Item> item = new List<Item> { };
        Job job = new Job(name, base_public_money, base_private_money, item);
        return job;
    }

    private Job Empty()
    {
        string name = "エラーです";
        uint base_public_money = 0;
        uint base_private_money = 0;
        List<Item> item = new List<Item> { };
        Job job = new Job(name, base_public_money, base_private_money, item);
        return job;
    }
}