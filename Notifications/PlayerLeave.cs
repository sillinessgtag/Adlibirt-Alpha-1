﻿using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;
using System.IO;
using UnityEngine;
using static Adlibirt.Menu.Main;

namespace Adlibirt.Notifications
{
    [HarmonyPatch(typeof(MonoBehaviourPunCallbacks), "OnPlayerLeftRoom")]
    internal class LeavePatch : MonoBehaviour
    {
        private static void Prefix(Player otherPlayer)
        {
            if (otherPlayer != PhotonNetwork.LocalPlayer && otherPlayer != a)
            {
                NotifiLib.SendNotification("<color=grey>[</color><color=red>LEAVE</color><color=grey>]</color> <color=white>Name: " + otherPlayer.NickName + "</color>");
                a = otherPlayer;
            }
        }

        private static Player a;
    }
}