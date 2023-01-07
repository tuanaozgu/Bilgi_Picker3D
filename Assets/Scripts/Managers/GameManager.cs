
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Self Variables

    #region Private Variables

    [SerializeField] private GameStates states;

    #endregion

    #endregion

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    private void OnEnable()
    {
        SubscribeEvents();
    }

    private void SubscribeEvents()
    {
        CoreGameSignals.Instance.onChangeGameState += OnChangeGameState;
    }
    private void UnSubscribeEvents()
    {
        CoreGameSignals.Instance.onChangeGameState -= OnChangeGameState;
    }
    private void OnDisable()
    {
        UnSubscribeEvents();
    }

    private void OnChangeGameState(GameStates state)
    {
        states = state;
    }
}
