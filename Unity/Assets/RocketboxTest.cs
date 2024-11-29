using System.Collections;
using System.Collections.Generic;
using Ubiq.Avatars.Rocketbox;
using Ubiq.Avatars;
using UnityEngine;

public class RocketboxTest : MonoBehaviour
{
    public RocketboxServerAddress server;
    public RocketboxAvatar avatar;

    public void LoadAvatar(string name)
    {
        StartCoroutine(RocketboxHelper.LoadFromUrlAsync(server.ResolveURI(name), avatar));
    }
}
