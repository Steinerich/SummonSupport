using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MinionBarHandler : MonoBehaviour
{
    private GameObject[] MinionBars;
    [SerializeField] 
    private GameObject prefabMinionBar;
    private RectTransform canvasTransform;
    private MinionHandler minionHandler;
    private int maxSummons;

    void Start()
    {
        canvasTransform = GetComponent<RectTransform>();
        minionHandler = GameObject.FindGameObjectWithTag("Player").GetComponent<MinionHandler>();
        maxSummons = minionHandler.settings.maxSummons;
        MinionBars = new GameObject[maxSummons];
    }
    public void AddMinion()
    {
        int i = minionHandler.settings.minions.Count-1;
        if (i < minionHandler.settings.maxSummons)
        {
            Vector2 mousePos = Input.mousePosition; 
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePos); 
            transform.position = worldPos;
            MinionBars[i] = Instantiate(prefabMinionBar, canvasTransform);
            minionHandler.settings.minions[i].GetComponent<StatHandler>().SetHealthBar(MinionBars[i].GetComponent<Slider>());
            RectTransform rectTransform = MinionBars[i].GetComponent<RectTransform>();
            float barHeight = rectTransform.rect.height;
            float canvasHeight = canvasTransform.rect.height;
            rectTransform.anchoredPosition = new Vector2(0, (-i * (canvasHeight / maxSummons)) - canvasHeight/ maxSummons/2);
        }

    }

}
