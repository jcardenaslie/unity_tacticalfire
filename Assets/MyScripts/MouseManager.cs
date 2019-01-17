using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    private List<Interactive> Selections = new List<Interactive>();
    // Update is called once per frame
    void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        var es = UnityEngine.EventSystems.EventSystem.current;
        if (es != null && es.IsPointerOverGameObject()) return; // Si no esta encima de un objeto

        if (Selections.Count > 0)
        { // si ya existen unidades seleccionadas
            foreach (var sel in Selections)
            {
                if (sel != null) sel.Deselect(); // deselecciona todas las unidades en el stack
            }
            Selections.Clear(); // vacia el stack
            // if (!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
            // { // Si no se esta apretando shift para agregar unidades
                
            // }
        }
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (!Physics.Raycast(ray, out hit)) return; // si no golpea nada sale


        var interact = hit.transform.GetComponent<Interactive>();
        if (interact == null) return; // si lo que golpea no es interactive

        // si super todo lo anterior, añade la unidad y seleccionala.
        Selections.Add(interact);
        interact.Select();
    }
}
