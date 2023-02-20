namespace Cassia.Impl
{
    [Flags]
    public enum WTS_SESSIONSTATE_FLAGS : uint
    {
        WTS_SESSIONSTATE_LOCK = 0,
        WTS_SESSIONSTATE_UNLOCK = 1,
        WTS_SESSIONSTATE_UNKNOWN = 4294967295,

    }
}