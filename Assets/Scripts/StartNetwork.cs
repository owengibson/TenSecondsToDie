using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

namespace TenSecondsToDie
{
    public class StartNetwork : MonoBehaviour
    {
        public void StartServer()
        {
            NetworkManager.Singleton.StartServer();
        }

        public void StartClient()
        {
            NetworkManager.Singleton.StartClient();
        }

        public void StartHost()
        {
            NetworkManager.Singleton.StartHost();
        }
    }
}