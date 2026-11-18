using UnityEngine;

public class spawnTimeUpgrade : Upgrade
{
    

    protected override void BuyUpgrade()
    {
        OreSpawn.instance.setSpawnTime(upgradeCount);
    }
}
