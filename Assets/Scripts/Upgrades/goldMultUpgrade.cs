using UnityEngine;

public class goldMultUpgrade : Upgrade
{

    protected override void BuyUpgrade()
    {
        GoldManager.Instance.IncreaseGoldMult(upgradeCount);
        UpdatePrice();
    }

    protected override void UpdatePrice()
    {
        Mathf.Max(Mathf.Pow(upgradeCount, 2) * 6, 10);
    }
}
