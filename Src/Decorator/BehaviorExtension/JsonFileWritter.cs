namespace Decorator.BehaviorExtension;

public sealed class JsonFileWritter : IFileWritter
{
    public async Task<bool> Write(string filePath, object obj)
    {
        throw new NotImplementedException();
        //try
        //{
        //    using StreamWriter outputFile = new(filePath);
        //    await outputFile.WriteAsync(JsonSerializer.Serialize(obj));
        //    return true;
        //}
        //catch (Exception)
        //{
        //    return false;
        //}
    }
}
