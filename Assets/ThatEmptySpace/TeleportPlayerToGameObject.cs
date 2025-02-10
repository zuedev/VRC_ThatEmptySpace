using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class TeleportPlayerToGameObject : UdonSharpBehaviour
{
    public GameObject target;

    void Start()
    {
        Debug.Log("Cube Start");
    }

    public override void Interact()
    {
        Networking.LocalPlayer.TeleportTo(target.transform.position, target.transform.rotation);
    }
}
