using UnityEngine;
using Zenject;

/// <summary>
/// Installer class for the Initialization scene.
/// This will bind all the necessary classes for the Initialization scene.
/// </summary>
public class InitializationInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        SignalBusInstaller.Install(Container);
        Container.BindInterfacesAndSelfTo<PersistantData>().AsSingle().NonLazy();
    }
}