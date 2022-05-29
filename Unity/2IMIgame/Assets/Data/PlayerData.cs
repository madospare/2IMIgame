using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{

    public bool lv1Cleared;
    public bool lv2Cleared;
    public bool lv3Cleared;

    public PlayerData (LevelUnlock lockstate)
    {
        lv1Cleared = lockstate.lv1Cleared;
        lv2Cleared = lockstate.lv2Cleared;
        lv3Cleared = lockstate.lv3Cleared;
    }

}
