using TMPro;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    public TextMeshProUGUI minionHP; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetupUI();
    }
    void Update()
    {
        UpdateUI();
    }
    private void SetupUI()
    {
        

    }

    private void UpdateUI()
    {
        AbilityHandler abilityHandler = GetComponent<AbilityHandler>();
        if (abilityHandler.minions.Length > 0)
        {
            StatHandler statHandler = abilityHandler.minions[0].GetComponent<StatHandler>();
            int hp = statHandler.GetHealth();
            minionHP.SetText(hp.ToString());
        }
    }
}
