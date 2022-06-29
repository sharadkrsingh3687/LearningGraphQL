using Autofac;
using MediatR;
using LearningGraphQL.Persist.Contract;
using LearningGraphQL.Persist;
using MediatR.Pipeline;
using FluentValidation;
using LearningGraphQL.Business.Features.Person;
using LearningGraphQL.Business.Behaviours;

namespace LearningGraphQL.Present.Domain.HumanResources
{
    public sealed class AutofacConfigModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Mediator>().As<IMediator>().InstancePerLifetimeScope();
            builder.RegisterType<AdventureWorksDbContext>().As<IAdventureWorksDbContext>().InstancePerDependency();
            builder.Register((c) => new AdventureWorksDataProvider(c.Resolve<IAdventureWorksDbContext>())).As<IAdventureWorksDataProvider>().InstancePerDependency();
            builder.RegisterGeneric(typeof(ValidationBehavior<,>)).As(typeof(IPipelineBehavior<,>)).InstancePerLifetimeScope();

            var mediatrOpenTypes = new[]
            {
                typeof(IRequestHandler<,>),
                typeof(IRequestExceptionHandler<,,>),
                typeof(IRequestExceptionAction<,>),
                typeof(INotificationHandler<>),
                typeof(IValidator<>)
            };

            foreach (var mediatrOpenType in mediatrOpenTypes)
            {
                builder.RegisterAssemblyTypes(typeof(GetAddressesQuery).Assembly)
                .AsClosedTypesOf(mediatrOpenType)
                .AsImplementedInterfaces();
            }

            builder.Register<ServiceFactory>(context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

        }
    }
}
