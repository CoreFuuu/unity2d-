using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//公司类
public class Company
{
    int companyID;  //唯一指定ID
    string companyName; //公司名称
    bool companyChoice; //公司性质 0国有 1私有
    int governmentAttitude; //政府好感
    List<int> outIdea;  //理念（公开）
    List<int> inIdea;   //理念（暗中）
    string companyCreator;  //创始人姓名
    List<int> creatorSkills;//创始人特质
    int compantLogo;    //公司标志

    public Company(string companyName, bool companyChoice, int governmentAttitude,
        List<int> outIdea, List<int> inIdea, string companyCreator, List<int> creatorSkills, int compantLogo)
    {
        this.companyID = UnityEngine.Random.Range(2, int.MaxValue / 2);
    }

    int getCompanyID()  //返回唯一指定ID
    {
        return this.companyID;
    }
    string getCompanyName() //返回公司名称
    {
        return this.companyName;
    }
    bool getCompanyChoice()
    {
        return this.companyChoice;
    }   //返回公司性质
    int getGovernmentAttitude() //返回政府好感
    {
        return this.governmentAttitude;
    }
    List<int> getOutIdea()
    {
        return this.outIdea;
    }
    List<int> getInIdea()
    {
        return this.inIdea;

    }
    string getCompantCreator()
    {
        return this.companyCreator;
    }
    List<int> getCreatorSkills()
    {
        return this.creatorSkills;
    }
    int getLogo()
    {
        return this.compantLogo;

    }

    void addOutIdea(int number) //去掉某个理念
    {
        this.outIdea.Remove(number);
    }



}