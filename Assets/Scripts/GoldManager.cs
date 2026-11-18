using TMPro;
using UnityEngine;

public class GoldManager : MonoBehaviour
{
    private static GoldManager instance;

    
    [SerializeField] private float gold;
    [SerializeField] private float goldMult;

    [SerializeField] private float critChance;
    [SerializeField] private float critAmount;
    [SerializeField] private TextMeshProUGUI text;

    public static GoldManager Instance {  get { return instance; } }

    private void Start()
    {
        if (instance == null)
            instance = this;

        goldMult = 1;
        UpdateGold();
    }

    public void AddGold(float goldAmount)
    {
        int randomRoll = Random.Range(1, 100);
        goldAmount *= goldMult;

        if (critChance >= randomRoll)
            goldAmount *= critAmount;

        gold += goldAmount;
        Debug.Log(gold);
        UpdateGold();
    }

    public void ReduceGold(float goldAmount)
    {
        gold -= goldAmount;
        UpdateGold();
    }

    public void IncreaseGoldMult(int upgradeCount)
    {
        goldMult = upgradeCount + 1;
    }

    public void IncreaseCritChance(int upgradeCount)
    {

        critChance = upgradeCount + 1;
    }

    public void IncreaseCritAmount(int upgradeCount)
    {

        critAmount = 10 * (1 + upgradeCount);
    }

    public float GetGoldAmount()
    {
        return gold;
    }

    private void UpdateGold()
    {
        text.text = "Gold:" + gold;
    }
}
