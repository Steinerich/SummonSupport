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
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null)
            {
                StatHandler targetScript = hit.collider.GetComponent<StatHandler>();
                if (targetScript != null)
                {
                    targetScript.AddHealth(10);
                }
            }
        }
    }

    public void SpawnMinions()
    {
        if (prefabMinion != null)
        {
            minions[0] = Instantiate(prefabMinion, new Vector3(0f, 0f, 0f), Quaternion.identity);
        }
    }
}
