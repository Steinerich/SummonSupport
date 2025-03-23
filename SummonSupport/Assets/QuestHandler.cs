using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;



public class QuestHandler : MonoBehaviour
{
    private AbilityHandler abilityHandler;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        abilityHandler = GameObject.FindWithTag("Player").GetComponent<AbilityHandler>();

    }

    // Update is called once per frame
    void Update()
    {
        if (abilityHandler.minions[0].GetComponent<StatHandler>().GetHealth() >= 100)
        {
            SceneManager.LoadScene("FirstLevel");
        }
    }
}
