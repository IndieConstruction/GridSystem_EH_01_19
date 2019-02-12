using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LevelManager : MonoBehaviour {
   
    List<Block> blocks = new List<Block>();
    List<RoutingPoint> routingPoints = new List<RoutingPoint>();
    List<Usable> usables = new List<Usable>();


    public void ClearAllData() {
        GetAllInterestingData();
        foreach (var item in blocks) {
            Destroy(item.gameObject);
        }
        foreach (var item in routingPoints) {
            Destroy(item.gameObject);
        }
        foreach (var item in usables) {
            Destroy(item.gameObject);
        }
    }

    public void SaveLevel() {
        List<ItemData> items = new List<ItemData>();

        GetAllInterestingData();
        foreach (var item in blocks) {
           items.Add(item.GetData());
        }
        foreach (var item in routingPoints) {
            items.Add(item.GetData());
        }
        foreach (var item in usables) {
            items.Add(item.GetData());
        }
    }

    public void GetAllInterestingData() {
        // Creo una lista di tutti i Block presenti nel livello.
        blocks = FindObjectsOfType<Block>().ToList();

        // Creo una lista di tutti i RoutingPoint presenti nel livello.
        routingPoints = FindObjectsOfType<RoutingPoint>().ToList();

        // Creo una lista di tutti i Usable presenti nel livello.
        usables = FindObjectsOfType<Usable>().ToList();
    }
}
