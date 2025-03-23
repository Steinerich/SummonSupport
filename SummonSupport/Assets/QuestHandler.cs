using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;



public class QuestHandler : MonoBehaviour
{
    private StatHandler statHandler;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StatHandler statHandler = GetComponent<StatHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (statHandler.GetHealth() >= 100)
        {
            SceneManager.LoadScene("FirstLevel");
        }
    }
}
