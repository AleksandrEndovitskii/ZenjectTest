using Managers;
using Zenject;

namespace DependencyInjection
{
    public class MainInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            // Same as below, but support multiple interfaces.
            //Container.BindInterfacesAndSelfTo<GameManager>().AsSingle();
            Container.Bind<IGameManager>().To<GameManager>().AsSingle();
            Container.Bind<ILightManager>().To<LightManager>().AsSingle();
        }
    }
}
