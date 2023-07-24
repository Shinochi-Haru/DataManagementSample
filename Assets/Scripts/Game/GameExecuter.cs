using Cysharp.Threading.Tasks;
using MD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// ゲーム起動してから最初に呼ばれるスクリプト
/// </summary>
class GameExecuter : MonoBehaviour
{
    void Start()
    {
        Execute();
    }

    async void Execute()
    {
        //マスタデータの読み込みをする
        //マスタデータ側に情報をリレーして更新処理を実行する
        await MasterData.Instance.Setup(false, () =>
        {
            Debug.Log("here");
        });
    }
}
