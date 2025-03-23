using TMPro;
using UnityEngine;

public class MinionBarHandler : MonoBehaviour
{
    private GameObject[] MinionBars;
    [SerializeField] 
    private GameObject prefabMinionBar;
    [SerializeField] 
    private int maxSummons = 4;
    [SerializeField] 
    private RectTransform canvasTransform; // Zum Setzen des Canvas als Parent

    void Start()
    {
        MinionBars = new GameObject[maxSummons];
        
        for (int i = 0; i < maxSummons; i++)
        {
            // MinionBar instanziieren und als Kind des Canvas hinzufügen
            MinionBars[i] = Instantiate(prefabMinionBar, canvasTransform);

            // RectTransform des MinionBars und des Canvas holen
            RectTransform rectTransform = MinionBars[i].GetComponent<RectTransform>();
            
            // Berechne die vertikale Position, um sie gleichmäßig zu verteilen
            float barHeight = rectTransform.rect.height;
            float canvasHeight = canvasTransform.rect.height;

            // Setze die Position der MinionBars
            rectTransform.anchoredPosition = new Vector2(0, (i * -canvasHeight / maxSummons) - canvasHeight/maxSummons/2);
        }
    }

    void Update()
    {
        // Hier kannst du weitere Logik hinzufügen
    }
}
