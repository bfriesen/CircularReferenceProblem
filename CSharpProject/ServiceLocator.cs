using System.ComponentModel.Composition.Hosting;

namespace CSharpProject
{
    internal static class ServiceLocator
    {
        private static readonly CompositionContainer _container =
            new CompositionContainer(new DirectoryCatalog(@".\"));

        public static T Get<T>()
        {
            return _container.GetExportedValue<T>();
        }
    }
}