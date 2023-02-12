using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject PlatformPrefab;

    public override void InstallBindings()
    {
        Container.Bind<PlatformPool>().AsSingle();

        //Bind and create a pool of 100 Platforms
        Container.BindMemoryPool<Platform, Platform.Pool>()
            .WithInitialSize(100)
            .FromComponentInNewPrefab(PlatformPrefab)
            .UnderTransformGroup("Platforms");
    }
}