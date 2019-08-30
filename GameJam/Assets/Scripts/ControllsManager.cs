using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllsManager : MonoBehaviour
{
    public GameObject player1controllsForConsole;
    public GameObject player2controllsForConsole;
    public GameObject player1controllsForKeyboard;
    public GameObject player2controllsForKeyboard;
    private int ifPlayer1usesConsole;
    private int ifPlayer2usesConsole;

    void Start()
    {
        PlayerPrefs.GetInt("player1ConsoleController", ifPlayer1usesConsole);
        PlayerPrefs.GetInt("player2ConsoleController", ifPlayer2usesConsole);
        if (ifPlayer1usesConsole == 1)
        {
            player1controllsForConsole.SetActive(true);
            player1controllsForKeyboard.SetActive(false);
        }
        if (ifPlayer2usesConsole == 1)
        {
            player2controllsForConsole.SetActive(true);
            player2controllsForKeyboard.SetActive(false);
        }
        if (ifPlayer1usesConsole == 0)
        {
            player1controllsForConsole.SetActive(false);
            player1controllsForKeyboard.SetActive(true);
        }
        if (ifPlayer2usesConsole == 0)
        {
            player2controllsForConsole.SetActive(false);
            player2controllsForKeyboard.SetActive(true);
        }
    }
    public void player1ConsoleController(string controllerName,int ifTrue)
    {
        PlayerPrefs.SetInt(controllerName, ifTrue);

    }
}
