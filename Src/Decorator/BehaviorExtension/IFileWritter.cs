namespace Decorator.BehaviorExtension;

public interface IFileWritter
{
    Task<bool> Write(string filePath, object obj);
}