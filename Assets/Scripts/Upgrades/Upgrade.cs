using UnityEngine;

public abstract class Upgrade : MonoBehaviour
{
    [SerializeField]
    protected int maxUpgrades = 10;
    protected int upgradeCount = 0;

    [SerializeField]
    protected int goldCost = 0;

    private void Start()
    {
        BuyUpgrade();
    }
    public void CheckUpgrade()
    {
        if (upgradeCount < maxUpgrades && goldCost < GoldManager.Instance.GetGoldAmount())
        {
            upgradeCount++;
            BuyUpgrade();
        }
    }

    protected abstract void BuyUpgrade();
}
