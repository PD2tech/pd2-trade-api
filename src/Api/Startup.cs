using Pd2TradeApi.Server.Lib.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Pd2TradeApi.Server.Api.Lib.Middleware;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authorization;
using Pd2TradeApi.Server.Api.Lib.Policies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Security.Claims;
using System;
using System.Linq;
using Pd2TradeApi.Server.Models.DTOs.Shared;
using System.Collections.Generic;
using Swashbuckle.AspNetCore.SwaggerUI;
using Pd2TradeApi.Server.Configuration;
using ChicksGold.Server.Api.Profiles;
using AutoMapper;

namespace Pd2TradeApi.Server.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.AddDatabase(Configuration);
            services.RegisterServices();

            services.AddMvc()
                .AddNewtonsoftJson(options => {
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                });


            services.AddJwtAuthentication(Configuration);
            services.AddScoped<IAuthorizationHandler, AuthorizationHandler>();
            services.AddAuthorization(options => {
                options.AddPolicy(JwtBearerDefaults.AuthenticationScheme, policy => {
                    policy.AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme);
                    policy.RequireClaim(ClaimTypes.NameIdentifier);
                });

                foreach(var permission in Enum.GetValues(typeof(AuthorizationPolicyType)).Cast<AuthorizationPolicyType>()) {
                    var name = Enum.GetName(typeof(AuthorizationPolicyType), permission);
                    options.AddPolicy(name, policy => {
                        policy.Requirements.Add(new AuthorizationRequirement(permission));
                    });
                }
            });

            services.AddAutoMapper(typeof(UserProfile));

            services
                .AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.IgnoreNullValues = true;
                });

            services.AddApplicationInsightsTelemetry(options => {
                options.InstrumentationKey = Configuration.TelemetryKey();
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Project Diablo 2 Trade Api", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                  {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                                  Enter 'Bearer' [space] and then your token in the text input below.
                                  \r\n\r\nExample: 'Bearer 12345abcdef'",
                     Name = "Authorization",
                     In = ParameterLocation.Header,
                     Type = SecuritySchemeType.ApiKey,
                     Scheme = "Bearer"
                   });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                  {
                    {
                      new OpenApiSecurityScheme
                      {
                        Reference = new OpenApiReference
                          {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                          },
                          Scheme = "oauth2",
                          Name = "Bearer",
                          In = ParameterLocation.Header,

                        },
                        new List<string>()
                      }
                 });
            });
            services.AddSwaggerGenNewtonsoftSupport();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            app.UseRouting();

            app.UseCors(builder =>
            {
                builder
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .SetIsOriginAllowed(host => true)
                    .AllowCredentials();
            });


            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Chicks Gold API V1");
                c.DocExpansion(DocExpansion.None);
                c.EnableDeepLinking();
                c.EnableValidator();

            });

            //app.UseMiddleware<CheckLoginIpMiddleware>();
            app.UseMiddleware<ErrorHandlingMiddleware>();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
