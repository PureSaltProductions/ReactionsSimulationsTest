using System.Collections.Generic;
using UnityEngine;

public class PlatformPool
{
    readonly Platform.Pool _platformPool;
    readonly List<Platform> _platforms = new List<Platform>();

    public PlatformPool(Platform.Pool platformPool)
    {
        _platformPool = platformPool;
    }

    public void AddFoo()
    {
        float maxSpeed = 10.0f;
        float minSpeed = 1.0f;

        _platforms.Add(_platformPool.Spawn(
            Random.onUnitSphere * Random.Range(minSpeed, maxSpeed)));
    }

    public void RemoveFoo()
    {
        var foo = _platforms[0];
        _platformPool.Despawn(foo);
        _platforms.Remove(foo);
    }
}
