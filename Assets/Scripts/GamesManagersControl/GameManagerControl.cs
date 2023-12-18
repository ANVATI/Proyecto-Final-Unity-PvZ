using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerControl : MonoBehaviour
{
    public int points;
    public int Soles = 3000;
    public Text TextPoints;
    public Text TextSoles;
    public GameObject plantPrefabRepetidora;
    public GameObject plantPrefabLanzaguisante;
    public GameObject plantPrefabHielo;
    public GameObject currentPlant;
    public GameObject Options;
    public GameObject Mensajes;
    public Text TextContador;
    public float time = 30;
    public GameObject ScoreZombies;
    
    void Start()
    {
        UpdatePoints(0);
    }
    void Update()
    {
        UpdateCounter();
    }

    public void UpdateSoles()
    {
        TextSoles.text = (Soles).ToString();
    }
    public void UpdatePoints(int score)
    {
        points = points + score;
        TextPoints.text = "Zombies Eliminados: " + points;

        if (points == 100)
        {
            SceneManager.LoadScene("Win");
        }
    }
    public void UpdateCounter()
    {
        time = time - Time.deltaTime;
        TextContador.text = "Los Zombies apareceran en: " + (time).ToString("F0");

        if (time < 0)
        {
            Mensajes.SetActive(false);
            ScoreZombies.SetActive(true); 
        }
    }

    public void AppearOptionsContainer()
    {
        Options.SetActive(true);
        Time.timeScale = 0;
    }
    public void DisappearOptionsContainer()
    {
        Options.SetActive(false);
        Time.timeScale = 1;
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene("Game");
        Options.SetActive(false);
        Time.timeScale = 1;
    }
    public void ReturnMenú()
    {
        SceneManager.LoadScene("Menú");
        Time.timeScale = 1;
    }
    public void CreatePlantRepetidora()
    {
        if (Soles > 0 && Soles >= 200)
        {
            if (currentPlant == null)
            {
                Soles = Soles - 200;
                currentPlant = Instantiate(plantPrefabRepetidora, transform.position, transform.rotation);
                UpdateSoles();
            }
        }
        else
        {
            print("No tienes money");
        }
    }
    public void CreatePlantLanzaguisante()
    {
        if (Soles > 0 && Soles >= 100)
        {
            if (currentPlant == null)
            {
                Soles = Soles - 100;
                currentPlant = Instantiate(plantPrefabLanzaguisante, transform.position, transform.rotation);
                UpdateSoles();
            }
        }
        else
        {
            print("No tienes money");
        }
    }
    public void CreatePlantHielo()
    {
        if (Soles > 0 && Soles >= 175)
        {
            if (currentPlant == null)
            {
                Soles = Soles - 175;
                currentPlant = Instantiate(plantPrefabHielo, transform.position, transform.rotation);
                UpdateSoles();
            }
        }
        else
        {
            print("No tienes money");
        }
    }
}
