using TMPro;
using UnityEngine;


public class MinionHandler : MonoBehaviour
{ 
    [System.Serializable]
    public struct Settings
    {
        public GameObject prefabMinion;
        public GameObject[] minions;
        public int maxSummons;

    }
    public Settings settings;
    

    void Start()
    {
        settings.minions = new GameObject[settings.maxSummons];
        SpawnMinions();

    }
    void Update()
    {
        
    }
    private void SpawnMinions()
    {
        if (settings.prefabMinion != null)
        {
            settings.minions[0] = Instantiate(settings.prefabMinion, new Vector3(0f, 0f, 0f), Quaternion.identity);
        }
    }
}
