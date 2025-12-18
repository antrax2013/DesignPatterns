namespace Decorator.BehaviorExtension;

public sealed class FileWritterTelemetryDecorator(IFileWritter fileWritter) : AFileWritterDecorator(fileWritter), IFileWritter
{
    public override async Task<bool> Write(string filePath, object obj)
    {
        throw new NotImplementedException();
        //var startTime = DateTime.UtcNow;
        //Console.WriteLine($"[Telemetry] Starting write operation at {startTime:O} for file: {filePath}");
        //bool result = await base.Write(filePath, obj);
        //var endTime = DateTime.UtcNow;
        //var duration = endTime - startTime;
        //Console.WriteLine($"[Telemetry] Completed write operation at {endTime:O} for file: {filePath}. Duration: {duration.TotalMilliseconds} ms");
        //return result;
    }
}
