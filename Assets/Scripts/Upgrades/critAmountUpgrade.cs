using UnityEngine;

public class critAmountUpgrade : Upgrade
{

    protected override void BuyUpgrade()
    {
        GoldManager.Instance.IncreaseCritAmount(upgradeCount);
        UpdatePrice();
    }

    protected override void UpdatePrice()
    {
        Mathf.Max(Mathf.Pow(upgradeCount, 3) * 3, 50);
    }
}
