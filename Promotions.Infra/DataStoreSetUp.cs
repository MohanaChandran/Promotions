using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Promotions.Infra
{
	public static class DataStoreSetUp
	{
		public static void AddDbContext(this IServiceCollection services ) =>
			services.AddDbContext<PromotionDBContext>(options =>
				options.UseNpgsql("Data Source=database.npgsql"));

	}
}
