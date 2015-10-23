#if NETCORE
namespace System.Reflection
{
    /// <summary>
    /// Workaround for lack of GetCallingAssembly in CoreFX. This will always return
    /// the Assembly containing this class, i.e. log4net. A slower workaround relying
    /// on enumerating loaded assemblies may be possible in the future
    /// (https://github.com/dotnet/corefx/issues/1784) but GetCallingAssembly
    /// will never be available because it's inherently unreliable
    /// (https://github.com/dotnet/corefx/issues/2221).
    /// </summary>
    public static class CallingAssemblyWorkaround
    {
        public static Assembly GetCallingAssembly()
        {
            return typeof(CallingAssemblyWorkaround).GetTypeInfo().Assembly;
        }
    }
}
#endif
