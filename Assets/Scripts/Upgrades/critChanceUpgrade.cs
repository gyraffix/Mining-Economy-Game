using UnityEngine;

public class critChanceUpgrade : Upgrade
{

    protected override void BuyUpgrade()
    {
        GoldManager.Instance.IncreaseCritChance(upgradeCount);
        UpdatePrice();
    }

    protected override void UpdatePrice()
    {
        Mathf.Max(Mathf.Pow(upgradeCount, 2) * 4, 15);
    }
}
