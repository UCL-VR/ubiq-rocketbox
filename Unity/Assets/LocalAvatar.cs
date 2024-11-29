using System.Collections;
using System.Collections.Generic;
using Ubiq.Avatars;
using Ubiq.Messaging;
using UnityEngine;

[DefaultExecutionOrder(-1)]
public class LocalAvatar : MonoBehaviour
{
    public AvatarManager AvatarManager;

    // Start is called before the first frame update
    void Start()
    {
        var avatar = GetComponent<Ubiq.Avatars.Avatar>();
        avatar.NetworkId = NetworkId.Create(this);
        avatar.IsLocal = true;
        avatar.SetInput(AvatarManager.input);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
