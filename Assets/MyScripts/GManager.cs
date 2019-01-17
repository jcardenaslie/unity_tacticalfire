using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{

    public static GManager Current = null;
    public List<PlayerSetupDefinition> Players = new List<PlayerSetupDefinition>();

    public Vector3? ScreenPointToMapPosition(Vector2 point){
        Ray ray = Camera.main.ScreenPointToRay(point);
        RaycastHit hit;
        if (!Physics.Raycast(ray, out hit, Mathf.Infinity)) return null;
        return hit.point;
    }

    void Start(){
        Current = this;
        foreach (var p in Players)
        {
            foreach (var u in p.StartingUnits)
            {
                // float range = 5;
                Vector3 random = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
                Vector3 position = p.Location.position - random;
                var go = GameObject.Instantiate(u, position, p.Location.rotation);
                var player = go.AddComponent<Player>();
                player.Info = p;

                if (!p.isAi)
                {
                    if (Player.Default == null) Player.Default = p;
                    go.AddComponent<RightClickNavigation>();
                    go.AddComponent<Interactive>();
                }    
            }
        }
    }
}
