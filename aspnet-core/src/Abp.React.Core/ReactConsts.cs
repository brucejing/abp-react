using Abp.React.Debugging;

namespace Abp.React;

public class ReactConsts
{
    public const string LocalizationSourceName = "React";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "4307c5b6b9f7465f8785f35d265621e9";
}
