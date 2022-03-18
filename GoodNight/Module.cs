using Autofac;

namespace DIConflictTest.GoodNight
{
    public class Module : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GoodNightService>().AsSelf();
            builder.RegisterType<NameProvider>().As<IHaveName>();
        }
    }
}