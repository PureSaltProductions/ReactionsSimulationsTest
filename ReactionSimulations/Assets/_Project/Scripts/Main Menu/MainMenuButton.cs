using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Zenject;

public class MainMenuButton : MonoBehaviour, IPointerClickHandler
{
    public enum ButtonType
    {
        Play,
        Exit
    }

    [SerializeField]
    private ButtonType _button;
    private SignalBus _signalBus;

    [Inject]
    private void Construct(SignalBus signalBus)
    {
        _signalBus= signalBus;
    }

    public void FireSignal()
    {
        _signalBus.Fire(new MainMenuButtonSignal(_button));
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        FireSignal();
    }
}
