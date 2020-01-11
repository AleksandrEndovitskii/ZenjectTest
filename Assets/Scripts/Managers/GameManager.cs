using UnityEngine;

namespace Managers
{
    public class GameManager : IGameManager
    {
        private ILightManager _lightManager;

        public GameManager(ILightManager lightManager)
        {
            _lightManager = lightManager;
        }

        public void Test()
        {
            Debug.Log("Test started");

            _lightManager.IsLightOn = false;

            Debug.Log("Test ended");
        }
    }
}
