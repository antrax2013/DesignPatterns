namespace Singleton;


public sealed class MemoryCache
{
    #region First responsability : Manage LifeCycle
    private static readonly Lazy<MemoryCache> _cache = new(() => new()); // new Lazy<MemoryCache>(() => new MemoryCache());
    public static MemoryCache GetInstance() => _cache.Value;

    private MemoryCache() => _cacheObjects = [];
    #endregion First responsability : Manage LifeCycle

    #region Second responsability : Manage Cache behavior
    private readonly Dictionary<string, object> _cacheObjects;

    public void Add(string key, object value) => _cacheObjects[key] = value;

    public object? Get(string key) => _cacheObjects.TryGetValue(key, out object? value) ? value : null;

    public void Remove(string v) => _cacheObjects.Remove(v);
    #endregion Second responsability : Manage Cache behavior
}
