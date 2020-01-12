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

        public void SwitchLightning()
        {
            Debug.Log("Lightning switched started");

            _lightManager.IsLightOn = !_lightManager.IsLightOn;

            Debug.Log("Lightning switched ended");
        }
    }
}
