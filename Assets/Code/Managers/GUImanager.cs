using UnityEngine;
using TMPro;
using System;
using UnityEngine.Events;

public class GUImanager : MonoBehaviour 
{
    public TMP_Text pointsText;

    public GameObject statMenu;

    public int CurrentPoints { get; private set; } = 0;

    public static UnityEvent OnPointsReceivedEvent;

    public void OnPointReceived(EventArgs args)
    {
        UpdatePoints();
    }

    private void Awake() 
    {
        statMenu.SetActive(false);

        OnPointsReceivedEvent = new UnityEvent();
        OnPointsReceivedEvent.AddListener(OnPointsReceived);
    }

    private void OnPointsReceived()
    {
        UpdatePoints();
    }

    public void UpdatePoints()
    {
        CurrentPoints++;
        pointsText.text = $"Points: {CurrentPoints}";
    }

    public void ShowStaMenu()
    {
        statMenu.SetActive(true);
    }

    public void HideStaMenu()
    {
        statMenu.SetActive(false);
    }
}