using UnityEngine;
using Zenject;

public class InitializationInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<PersistantData>().AsSingle();
        Container.Bind<SceneController>().AsSingle();
    }
}