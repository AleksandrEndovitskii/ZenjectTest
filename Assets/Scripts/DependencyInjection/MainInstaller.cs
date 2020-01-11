using Managers;
using Zenject;

namespace DependencyInjection
{
    public class MainInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IGameManager>().To<GameManager>().AsSingle();
            Container.Bind<ILightManager>().To<LightManager>().AsSingle();
        }
    }
}
