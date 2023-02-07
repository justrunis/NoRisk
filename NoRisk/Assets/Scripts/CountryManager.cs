using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryManager : MonoBehaviour
{

    public static CountryManager instance;
    public List<GameObject> countryList = new List<GameObject>();
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        AddCountryData();
    }
    
    void AddCountryData()
    {
        GameObject[] countries = GameObject.FindGameObjectsWithTag("Country") as GameObject[];
        foreach (GameObject country in countries)
        {
            countryList.Add(country);
        }
        SelectRandomPlayerCountry();
        TintCountries();
    }

    void TintCountries()
    {
        for (int i = 0; i < countryList.Count; i++)
        {
            MapClickDetector countryHandler = countryList[i].GetComponent<MapClickDetector>();
            if (countryHandler.country.tribe == Country.theTribes.HUNTERS)
            {
                countryHandler.TintColor(new Color32(255,0,0,128));
            }
            if (countryHandler.country.tribe == Country.theTribes.KNIGHTS)
            {
                countryHandler.TintColor(new Color32(0, 0, 255, 128));
            }
            if (countryHandler.country.tribe == Country.theTribes.ORCS)
            {
                countryHandler.TintColor(new Color32(0, 255, 0, 128));
            }
            if (countryHandler.country.tribe == Country.theTribes.MAGES)
            {
                countryHandler.TintColor(new Color32(255, 255, 0, 128));
            }
            if (countryHandler.country.tribe == Country.theTribes.PLAYER)
            {
                countryHandler.TintColor(new Color32(0, 0, 0, 0));
            }
        }
    }

    void SelectRandomPlayerCountry()
    {
        System.Random random = new System.Random();
        var countryIndex = random.Next(countryList.Count);
        MapClickDetector countryHandler = countryList[countryIndex].GetComponent<MapClickDetector>();
        countryHandler.country.tribe = Country.theTribes.PLAYER;
    }
}
