using System;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

public class PlayFabBasic : MonoBehaviour
{
    void Start()
        => PlayFabClientAPI.LoginWithCustomID(new () {
            CreateAccount = true,
            CustomId = SystemInfo.deviceUniqueIdentifier,
        }, response => {
            Debug.Log($"PlayFabID={response.PlayFabId}");
        }, error => {
            Debug.LogError(error.GenerateErrorReport());
        });
}
