using TMPro;
using UnityEngine;
using System.Collections.Generic;


public class MinionHandler : MonoBehaviour
{ 
    [System.Serializable]
    public struct Settings
    {
        public GameObject prefabMinion;
        public List<GameObject> minions;
        public int maxSummons;
        public GameObject minionBar;

    }
    public Settings settings;
    
    MinionBarHandler minionBarHandler;

    void Start()
    {
        settings.minions = new List<GameObject>();
    }
    void Update()
    {
        
    }
    public void SpawnMinion()
    {
        if (settings.prefabMinion != null && settings.minions.Count < settings.maxSummons)
        {
            MinionBarHandler minionBarHandler = settings.minionBar.GetComponent<MinionBarHandler>();    
            settings.minions.Add(Instantiate(settings.prefabMinion, new Vector3(0f, 0f, 0f), Quaternion.identity));
            minionBarHandler.AddMinion();
        }
    }
}
