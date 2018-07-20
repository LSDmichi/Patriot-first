using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Job
{
    public string job_name;
    public uint additional_public_money_from_job;
    public uint additional_private_money_from_job;
    public List<Item> addtional_item_list_from_job;

    public Job JobSpec(string name, uint base_public_money, uint base_private_money, List<Item> addtional_item)
    {
        Job user_job = new Job();
        user_job.job_name = name;
        user_job.additional_public_money_from_job = base_public_money;
        user_job.additional_private_money_from_job = base_private_money;
        user_job.addtional_item_list_from_job = addtional_item;
        return user_job;
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
        Job job = new Job();
        job = job.JobSpec(name, base_public_money, base_private_money, item);
        return job;
    }

    private Job Research()
    {
        string name = "研究";
        uint base_public_money = 200000;
        uint base_private_money = 50000;
        List<Item> item = new List<Item> { };
        Job job = new Job();
        job = job.JobSpec(name, base_public_money, base_private_money, item);
        return job;
    }

    private Job Stock()
    {
        string name = "備蓄";
        uint base_public_money = 250000;
        uint base_private_money = 0;
        List<Item> item = new List<Item> { };
        Job job = new Job();
        job = job.JobSpec(name, base_public_money, base_private_money, item);
        return job;
    }

    private Job Military()
    {
        string name = "軍備";
        uint base_public_money = 200000;
        uint base_private_money = 50000;
        List<Item> item = new List<Item> { };
        Job job = new Job();
        job = job.JobSpec(name, base_public_money, base_private_money, item);
        return job;
    }

    private Job Empty()
    {
        string name = "エラーです";
        uint base_public_money = 0;
        uint base_private_money = 0;
        List<Item> item = new List<Item> { };
        Job job = new Job();
        job = job.JobSpec(name, base_public_money, base_private_money, item);
        return job;
    }
}