namespace DotNet.MinimalApi.Htmx.Infrastructure;


public static class HtmxRequestKeys
{
    public const string Boosted = "HX-Boosted";
    public const string CurrentUrl = "HX-Current-URL";
    public const string HistoryRestoreRequest = "HX-History-Restore-Request";
    public const string Prompt = "HX-Prompt";
    public const string Request = "HX-Request";
    public const string Target = "HX-Target";
    public const string TriggerName = "HX-Trigger-Name";
    public const string Trigger = "HX-Trigger";
    

    public static string[] All { get;  } =
    [
        Boosted, CurrentUrl, HistoryRestoreRequest, Prompt, Request, Target, TriggerName, Trigger
    ];
}

public static class HtmxHttpExtensions
{
    public static bool IsHtmx(this HttpRequest request) => request.Headers.ContainsKey(HtmxRequestKeys.Request);
}