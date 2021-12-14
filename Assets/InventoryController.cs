using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{

    [SerializeField] ItemGrid SelectedItemGrid;

    private void Update()
    {
        if (SelectedItemGrid == null) { return; }

        Debug.Log(SelectedItemGrid.GetTileGridPosition(Input.mousePosition));
    }
}
