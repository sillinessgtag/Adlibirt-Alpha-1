﻿using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;
using System.IO;
using UnityEngine;
using static Adlibirt.Menu.Main;

namespace Adlibirt.Notifications
{
    [HarmonyPatch(typeof(MonoBehaviourPunCallbacks), "OnPlayerEnteredRoom")]
    internal class JoinPatch : MonoBehaviour
    {
        private static void Prefix(Player newPlayer)
        {
            if (newPlayer != oldnewplayer)
            {
                NotifiLib.SendNotification("<color=grey>[</color><color=green>JOIN</color><color=grey>] </color><color=white>Name: " + newPlayer.NickName + "</color>");
                oldnewplayer = newPlayer;
            }
        }

        private static Player oldnewplayer;
    }
}