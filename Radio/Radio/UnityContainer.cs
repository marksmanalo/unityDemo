using Unity;
using Unity.Injection;
using Unity.RegistrationByConvention;

namespace Radio
{
    public class UnityContainer
    {
        public static void RegisterElements(IUnityContainer container)
        {
            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies(),
                WithMappings.FromMatchingInterface,
                WithName.Default,
                WithLifetime.ContainerControlled);

            container.RegisterType<Casing>(new InjectionConstructor("Plastic"));
        }
    }
}
