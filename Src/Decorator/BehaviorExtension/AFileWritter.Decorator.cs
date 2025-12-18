namespace Decorator.BehaviorExtension;

public abstract class AFileWritterDecorator(IFileWritter fileWritter) : IFileWritter
{
    public virtual Task<bool> Write(string filePath, object obj)
    {
        return fileWritter.Write(filePath, obj);
    }
}
