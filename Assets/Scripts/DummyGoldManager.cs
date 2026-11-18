using Unity.VisualScripting;
using UnityEngine;

public class DummyGoldManager : MonoBehaviour
{
    public void CallGoldManager()
    {
        GoldManager.Instance.AddGold(1);
        Destroy(this.gameObject);
        OreSpawn.instance.DecreaseSpawnCount();
    }
}
