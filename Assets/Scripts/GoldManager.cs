using UnityEngine;

public class GoldManager : MonoBehaviour
{
    private GoldManager instance;

    
    [SerializeField] private float gold;
    [SerializeField] private float goldMult;

    [SerializeField] private float critChance;
    [SerializeField] private float critAmount;

    public GoldManager Instance {  get { return instance; } }

    private void Start()
    {
        if (instance == null)
            instance = this;

        goldMult = 1;
    }

    public void AddGold(float goldAmount)
    {
        int randomRoll = Random.Range(1, 100);
        goldAmount *= goldMult;

        if (critChance <= randomRoll)
            goldAmount *= critAmount;

        gold += goldAmount;
        Debug.Log(gold);
    }

    public void ReduceGold(float goldAmount)
    {
        gold -= goldAmount;
    }

    public void IncreaseCritChance(int upgradeCount)
    {

        //critChance += critChanceIncrease;
    }

    public void IncreaseCritAmount(int upgradeCount)
    {

        //critAmount += critAmountIncrease;
    }

    public float GetGoldAmount()
    {
        return gold;
    }
}
