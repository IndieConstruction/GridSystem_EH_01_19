﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public const string LEVELSAVES = "LevelSaves";

    public string LevelToLoad;

    public Button ButtonLoadLevelPrefab;
    public GameObject ButtonsContainer;

    List<Block> blocks = new List<Block>();
    List<RoutingPoint> routingPoints = new List<RoutingPoint>();
    List<Usable> usables = new List<Usable>();

    public GameObject BlockPrefab;
    public GameObject RoutingPointPrefab;
    public GameObject UsablePrefab;

    public List<string> LevelsID = new List<string>();

    private void Start() {

        string jsonStringLevelSaves = PlayerPrefs.GetString(LEVELSAVES);
        LevelSaves levelSaves = JsonUtility.FromJson<LevelSaves>(jsonStringLevelSaves);
        LevelsID = levelSaves.LevelsID;

        foreach (string levelId in LevelsID) {
            Debug.LogFormat("Level {0} found!", levelId);
            Button newButton = Instantiate<Button>(ButtonLoadLevelPrefab, ButtonsContainer.transform);
            newButton.GetComponentInChildren<Text>().text = levelId;
            newButton.onClick.AddListener(() => LoadLevel(levelId));
        }

    }

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

    List<ItemData> items = new List<ItemData>();

    public void SaveLevel() {

        items = new List<ItemData>();

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

        LevelData saveClass = new LevelData();

        saveClass.ID = "Level" + (LevelsID.Count + 1).ToString();
        LevelsID.Add(saveClass.ID);
        Debug.LogFormat("{0} saved!", saveClass.ID);
        saveClass.Items = items;
        // Salvo livello
        string jsonString = JsonUtility.ToJson(saveClass);
        PlayerPrefs.SetString(saveClass.ID, jsonString);
        // Salvo il nome del livello nella lista dei livelli
        LevelSaves levelSaves = new LevelSaves();
        levelSaves.LevelsID = LevelsID;
        string jsonStringForLevelID = JsonUtility.ToJson(levelSaves);
        PlayerPrefs.SetString(LEVELSAVES, jsonStringForLevelID);
        PlayerPrefs.Save();
    }

    public void LoadLevel(string _levelID = "") {

        ClearAllData();

        if (_levelID == "")
            _levelID = LevelToLoad;

        string jsonLevelStringData = PlayerPrefs.GetString(_levelID);

        LevelData level = JsonUtility.FromJson<LevelData>(jsonLevelStringData);

        foreach (ItemData item in level.Items) {
            switch (item.ItemType) {
                case ItemData.Type.Block:
                    Instantiate(BlockPrefab, item.GridPosition, Quaternion.identity);
                    break;
                case ItemData.Type.Point:
                    Instantiate(RoutingPointPrefab, item.GridPosition, Quaternion.identity);
                    break;
                case ItemData.Type.Usable:
                    Instantiate(UsablePrefab, item.GridPosition, Quaternion.identity);
                    break;
                default:
                    break;
            }
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

[Serializable]
public class LevelData {
    public string ID;
    public List<ItemData> Items;
}

public class LevelSaves {
    public List<string> LevelsID;
}
