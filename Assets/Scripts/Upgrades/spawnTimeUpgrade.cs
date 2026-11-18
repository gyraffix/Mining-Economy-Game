using UnityEngine;

public class spawnTimeUpgrade : Upgrade
{
    

    protected override void BuyUpgrade()
    {
        OreSpawn.instance.setSpawnTime(upgradeCount);
        UpdatePrice();
    }

    protected override void UpdatePrice()
    {
        goldCost = (int)Mathf.Floor(Mathf.Max(Mathf.Pow(upgradeCount, 1.8f) * 5, 10));
    }
}
