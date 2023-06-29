using BlazorWasmApp;

public class TimeFormatter
{
    ITimeService timeService;
    public TimeFormatter(ITimeService timeService)
    {
        this.timeService = timeService;
    }
    public string FormatTime() => $"Current Time: {timeService.GetTime()}";
}