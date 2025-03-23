using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class AbilityHandler : MonoBehaviour
{
    public GameObject prefabMinion;
    public GameObject[] minions;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        minions = new GameObject[1]; 
        SpawnMinions();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInputs();
    }
    private void CheckInputs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SmolHeal();
        }
        if (Input.GetMouseButtonDown(1))
        {
            BigHeal();
        }
    }
    private RaycastHit2D GetTargetOnClick()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        return hit;
        
    }
    private void Heal(int value)
    {
        RaycastHit2D hit = GetTargetOnClick();
        if (hit.collider != null)
        {
            StatHandler targetScript = hit.collider.GetComponent<StatHandler>();
            if (targetScript != null)
            {
                targetScript.AddHealth(value);
            }
        }
        
    }
    private void SmolHeal()
    {
        Heal(10);
    }
    private void BigHeal()
    {
        Heal(20);
    }

    private void SpawnMinions()
    {
        if (prefabMinion != null)
        {
            minions[0] = Instantiate(prefabMinion, new Vector3(0f, 0f, 0f), Quaternion.identity);
        }
    }
}
