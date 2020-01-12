using System;
using System.Collections;
using Managers;
using UnityEngine;
using Zenject;

public class TestDependencyInjection : MonoBehaviour
{
    private IGameManager _gameManager;

    private Coroutine _stopwatchCoroutine = null;

    [Inject]
    public void Construct(IGameManager gameManager)
    {
        _gameManager = gameManager;
    }

    private void OnDestroy()
    {
        if (_stopwatchCoroutine != null)
        {
            StopCoroutine(_stopwatchCoroutine);

            _stopwatchCoroutine = null;
        }
    }

    IEnumerator StopwatchCoroutine(Action action)
    {
        while (true)
        {
            if (action != null)
            {
                action.Invoke();
            }

            yield return new WaitForSeconds(1f);
        }
    }

    private void Start()
    {
        _stopwatchCoroutine = StartCoroutine(StopwatchCoroutine(() =>
        {
            _gameManager.SwitchLightning();
        }));
    }
}
