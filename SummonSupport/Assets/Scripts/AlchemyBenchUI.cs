using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;

public class AlchemyBenchUI : MonoBehaviour
{

    [SerializeField] UIDocument ui;
    private VisualElement root;
    private VisualElement interactWindow;
    private Label interactLabel;
    private VisualElement craftingUI;
    private VisualElement craftandUpgrade;
    private Label instructions;
    public UnityEvent playerUsingUI;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        root = ui.rootVisualElement;
        interactWindow = root.Q<VisualElement>("Interact");
        craftingUI = root.Q<VisualElement>("CraftingUI");
        craftandUpgrade = craftingUI.Q<VisualElement>("CraftandUpgrade");
        instructions = craftandUpgrade.Q<Label>("Instructions");
        interactLabel = interactWindow.Q<Label>("InteractLabel");
        interactWindow.style.display = DisplayStyle.None;
        craftingUI.style.display = DisplayStyle.None;


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            interactWindow.style.display = DisplayStyle.Flex;
            interactLabel.text = "Press Tab to Interact";
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("Tab key pressed!");
            PlayerUsingUI();
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.Tab))

        {
            InteractWithWorkBench();
        }
        //else Debug.Log("player is not pressing tab");
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            interactWindow.style.display = DisplayStyle.None;
            craftingUI.style.display = DisplayStyle.None;
        }
    }

    private void PlayerUsingUI()
    {
        playerUsingUI?.Invoke();
    }
    private void InteractWithWorkBench()
    {
        PlayerUsingUI();
        craftingUI.style.display = DisplayStyle.Flex;
        Button craftButton = craftingUI.Q<Button>("CraftButton");
        Button upgradeButton = craftingUI.Q<Button>("UpgradeButton");
        Button recycleButton = craftingUI.Q<Button>("RecycleButton");
        Button quitButton = craftingUI.Q<Button>("QuitButton");

        craftButton.RegisterCallback<ClickEvent>(e => ShowCraftingOptions());
        upgradeButton.RegisterCallback<ClickEvent>(e => ShowUpgradeOptions());
        recycleButton.RegisterCallback<ClickEvent>(e => ShowRecycleOptions());
        quitButton.RegisterCallback<ClickEvent>(e => QuitAlchemyUI());

    }
    private void QuitAlchemyUI()
    {
        craftingUI.style.display = DisplayStyle.None;
        PlayerUsingUI();
    }

    private void ShowCraftingOptions()
    {
        instructions.text = "Combine Cores, Ether and Body Parts to make mions.";
    }
    private void ShowUpgradeOptions()
    {
        instructions.text = "Which Minion would you like to upgrade?";
    }
    private void ShowRecycleOptions()
    {
        instructions.text = "Which Minion would you like to recycle for components?";
    }

    //Button backButton = new Button { text = "Back" };
    //backButton.RegisterCallback<ClickEvent>(a => instructions.text = "");

}
