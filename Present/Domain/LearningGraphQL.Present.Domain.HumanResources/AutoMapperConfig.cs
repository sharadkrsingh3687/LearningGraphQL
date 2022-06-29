using AutoMapper;
using LearningGraphQL.Business.Mapper;
using LearningGraphQL.Framework.Common;

namespace LearningGraphQL.Present.Domain.HumanResources
{
	public class AutoMapperConfig
	{
		public IMapper Configure()
		{
			var profiles = AppDomain.CurrentDomain.GetAssemblies()
			  .SelectMany(s => s.GetTypes())
			  .Where(a => typeof(ProfileMapper).IsAssignableFrom(a));

			var autoMapperConfig = new MapperConfiguration(a => profiles.ForEach(a.AddProfile));

			return autoMapperConfig.CreateMapper();
		}
	}	
}
