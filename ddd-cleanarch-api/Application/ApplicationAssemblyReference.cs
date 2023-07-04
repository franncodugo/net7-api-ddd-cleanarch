using System.Reflection;

namespace Application;

public sealed class ApplicationAssemblyReference
{

    internal readonly Assembly assembly = typeof(ApplicationAssemblyReference).Assembly;
}
