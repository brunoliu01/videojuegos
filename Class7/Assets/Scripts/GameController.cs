using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text textPuntos;
    public Text textTitle;

    private int puntaje;
    private const string KEY_PUNTAJE = "PUNTOS_GUARDADOS";

    public int puntosAGanar;

    public void Start()
    {
        puntaje = PlayerPrefs.GetInt(KEY_PUNTAJE, 0);
        textPuntos.text = "Puntos: " + puntaje.ToString();
    }

    public void AddPoints()
    {
        puntaje += puntosAGanar;
        PlayerPrefs.SetInt(KEY_PUNTAJE, puntaje);
        textPuntos.text = "Puntos: " + puntaje.ToString();
    }

    public void Lose()
    {
        textTitle.text = "Perdiste :(";
    }
}
