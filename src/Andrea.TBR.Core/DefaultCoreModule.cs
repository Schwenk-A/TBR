using Autofac;
using Andrea.TBR.Core.Interfaces;
using Andrea.TBR.Core.Services;

namespace Andrea.TBR.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
