using Managers;
using UnityEngine;
using Zenject;

public class TestDependencyInjection : MonoBehaviour
{
    private IGameManager _gameManager;

    [Inject]
    public void Initialization(IGameManager gameManager)
    {
        _gameManager = gameManager;
    }

    private void Start()
    {
        _gameManager.Test();
    }
}
