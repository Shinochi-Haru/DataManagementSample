using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// 設定ファイル
/// </summary>
[CreateAssetMenu(fileName = "GameSetting", menuName = "DataManagementSample/GameSetting", order = 1)]
public class GameSettingObject : ScriptableObject
{
    public string MasterDataAPIURI;
}