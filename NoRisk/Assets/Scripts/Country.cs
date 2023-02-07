using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Country
{
    public string name;
    public enum theTribes
    {
        PLAYER,
        HUNTERS,
        MAGES,
        ORCS,
        KNIGHTS
    }

    public theTribes tribe;

    public int moneyReward;
    public int expReward;
}
