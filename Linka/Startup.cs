using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkaRepository.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using LinkaRepository.Repositories.AuthRepositories;
using LinkaRepository.Repositories.ShoppingRepositories;
using AutoMapper;
using Linka.Mapping;
using Linka.Libs;
using Microsoft.AspNetCore.Http;
using LinkaRepository.Repositories.BlogRepositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;



namespace Linka
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();
			services.AddMvc(config =>
			{
				config.Filters.Add(new GlobalToken());
			});


			services.AddDbContext<LinkaDbContext>(options =>
				   options.UseSqlServer(Configuration.GetConnectionString("Default"),
				   x => x.MigrationsAssembly("LinkaRepository")));

			services.AddTransient<IAuthRepository, AuthRepository>();
			services.AddTransient<IProductRepository, ProductRepository>();
			services.AddTransient<IBasketRepository, BasketRepository>();
			services.AddTransient<IBlogRepository, BlogRepository>();


			//Inner Libs
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			services.AddTransient<IAuth, Auth>();

			// Auto Mapper Configurations
			var mappingConfig = new MapperConfiguration(mc =>
			{
				mc.AddProfile(new MappingProfile());
			});

			IMapper mapper = mappingConfig.CreateMapper();
			services.AddSingleton(mapper);


			services.AddMvc();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
