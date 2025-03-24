using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;

public class AlchemyBenchUI : MonoBehaviour
{

    [SerializeField] UIDocument ui;
    private VisualElement root;
    private VisualElement interactWindow;
    private Label interactLabel;
    public UnityEvent playerUsingUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        root = ui.rootVisualElement;
        interactWindow = root.Q<VisualElement>("Interact");
        interactLabel = interactWindow.Q<Label>("InteractLabel");
        interactWindow.style.display = DisplayStyle.None;

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
            Debug.Log("Tab key pressed!");
            PlayerUsingUI();
        }
        //else Debug.Log("player is not pressing tab");
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) interactWindow.style.display = DisplayStyle.None;
    }

    private void PlayerUsingUI()
    {
        playerUsingUI?.Invoke();
    }


}
