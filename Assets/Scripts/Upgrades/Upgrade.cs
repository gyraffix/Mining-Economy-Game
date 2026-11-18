using UnityEngine;

public abstract class Upgrade : MonoBehaviour
{
    [SerializeField]
    protected int maxUpgrades = 10;
    protected int upgradeCount = 0;

    [SerializeField]
    protected int goldCost = 0;


    public void CheckUpgrade()
    {
        if (upgradeCount < maxUpgrades && goldCost < 1000)
        {
            upgradeCount++;
            BuyUpgrade();
        }
    }

    protected abstract void BuyUpgrade();
}
