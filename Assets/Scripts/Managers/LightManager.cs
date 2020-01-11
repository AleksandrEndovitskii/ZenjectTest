using System.Linq;
using UnityEngine;

namespace Managers
{
    public class LightManager : ILightManager
    {
        public bool IsLightOn
        {
            get
            {
                var result = true;

                var lights = GameObject.FindObjectsOfType<Light>().ToList();
                foreach (var light in lights)
                {
                    if (light.enabled == false)
                    {
                        result = false;
                    }
                }

                return result;
            }
            set
            {
                if (value == IsLightOn)
                {
                    return;
                }

                var bufferValue = IsLightOn;

                var lights = GameObject.FindObjectsOfType<Light>().ToList();
                lights.ForEach(l => l.enabled = value);

                Debug.Log(string.Format("IsLightOn changed from {0} to {1}",
                    IsLightOn, bufferValue));
            }
        }
    }
}
