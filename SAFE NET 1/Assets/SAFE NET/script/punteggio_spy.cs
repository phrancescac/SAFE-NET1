using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class punteggio_spy : MonoBehaviour
{
    public Text scoreText;
    public Text tentativoText;
    private int tentativi = 0;

    private bool cliccato = false;
    private bool cliccato1 = false;
    private bool cliccato2 = false;

    static private int score = 0;
    static public int punteggioTot = 0;

    public Text puntTotText;

    public void Start()
    {
        // Azzera il punteggio individuale all'inizio del gioco
        score = 0;
        // Azzera i tentativi all'inizio del gioco
        tentativi = 0;
        tentativoText.text = tentativi.ToString();
    }

    public void bt_giusto()
    {
        if (!cliccato)
        {
            score++;
            scoreText.text = score.ToString();
            cliccato = true;
            punteggioTot++;
        }
        else
        {
            Debug.Log("Hai già scovato l'hacker in questa finestra.");
        }

        tentativi++;
        tentativoText.text = tentativi.ToString();
        caricaScena();
    }

    public void bt_giusto1()
    {
        if (!cliccato1)
        {
            score++;
            scoreText.text = score.ToString();
            cliccato1 = true;
            punteggioTot++;
        }
        else
        {
            Debug.Log("Hai già scovato l'hacker in questa finestra.");
        }

        tentativi++;
        tentativoText.text = tentativi.ToString();
        caricaScena();
    }

    public void bt_giusto2()
    {
        if (!cliccato2)
        {
            score++;
            scoreText.text = score.ToString();
            cliccato2 = true;
            punteggioTot++;
        }
        else
        {
            Debug.Log("Hai già scovato l'hacker in questa finestra.");
        }

        tentativi++;
        tentativoText.text = tentativi.ToString();
        caricaScena();
    }

    public void bt_sbagliato()
    {
        tentativi++;
        tentativoText.text = tentativi.ToString();

        if (tentativi >= 4)
        {
            // Se il numero di tentativi supera o è uguale a 4, carica la scena di game over
            SceneManager.LoadScene("gameover_spyware");
        }
    }

    public void caricaScena()
    {
        if (score >= 3)
        {
            // Quando il punteggio raggiunge 3, carica la scena di vittoria
            SceneManager.LoadScene("victory_spyware");
        }
    }
}
