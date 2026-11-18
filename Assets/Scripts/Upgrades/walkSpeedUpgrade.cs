using StarterAssets;
using UnityEngine;

public class walkSpeedUpgrade : Upgrade
{
    [SerializeField]
    private ThirdPersonControllerFixed player;

    protected override void BuyUpgrade()
    {
        player.SprintSpeed = 5.335f + upgradeCount;
    }
}
