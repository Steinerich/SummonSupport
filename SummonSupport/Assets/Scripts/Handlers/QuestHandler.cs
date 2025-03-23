using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;



public class QuestHandler : MonoBehaviour
{
    private MinionHandler minionHandler;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        minionHandler = GameObject.FindWithTag("Player").GetComponent<MinionHandler>();

    }

    // Update is called once per frame
    void Update()
    {
        if (minionHandler.settings.minions[0].GetComponent<StatHandler>().GetHealth() >= 100)
        {
            SceneManager.LoadScene("FirstLevel");
        }
    }
}
