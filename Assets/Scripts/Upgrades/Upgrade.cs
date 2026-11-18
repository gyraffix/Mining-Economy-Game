using TMPro;
using UnityEngine;

public abstract class Upgrade : MonoBehaviour
{
    [SerializeField]
    protected int maxUpgrades = 10;
    protected int upgradeCount = 0;

    [SerializeField]
    protected int goldCost = 0;

    [SerializeField]
    private string upgradeName;

    [SerializeField]
    private TextMeshProUGUI nameText;
    [SerializeField]
    private TextMeshProUGUI countText;
    [SerializeField]
    private TextMeshProUGUI costText;

    private void Start()
    {
        BuyUpgrade();
        UpdateText();
    }
    public void CheckUpgrade()
    {
        if (upgradeCount < maxUpgrades && goldCost < GoldManager.Instance.GetGoldAmount())
        {
            upgradeCount++;
            GoldManager.Instance.ReduceGold(goldCost);
            BuyUpgrade();
            UpdateText();
        }
    }

    protected void UpdateText()
    {
        nameText.text = upgradeName;
        countText.text = upgradeCount + "/" + maxUpgrades;
        costText.text = goldCost + " Gold";
    }

    protected abstract void UpdatePrice();

    protected abstract void BuyUpgrade();
}
