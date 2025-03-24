using UnityEngine;
using UnityEngine.UIElements;

public class AlchemyBenchUI : MonoBehaviour
{

    [SerializeField] UIDocument ui;
    private VisualElement root;
    private VisualElement interactWindow;
    private Label interactLabel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        root = ui.rootVisualElement;
        interactWindow = root.Q<VisualElement>("Interact");
        interactLabel = interactWindow.Q<Label>("InteractLabel");
        interactWindow.style.flexGrow = 0;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) interactWindow.style.flexGrow = 1;


    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) interactWindow.style.flexGrow = 0;


    }



}
