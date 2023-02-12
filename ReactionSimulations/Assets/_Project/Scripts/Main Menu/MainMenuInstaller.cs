using UnityEngine;
using Zenject;

public class MainMenuInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //Container.Bind<MainMenuButton>().AsCached();
        Container.DeclareSignal<MainMenuButtonSignal>();
    }
}