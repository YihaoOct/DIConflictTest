using Autofac;

namespace DIConflictTest.GoodMorning
{
    public class Module : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GoodMorningService>().AsSelf();
            builder.RegisterType<NameProvider>().As<IHaveName>();
        }
    }
}