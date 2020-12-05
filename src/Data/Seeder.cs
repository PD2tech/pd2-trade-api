using Pd2TradeApi.Server.Models.DTOs.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace Pd2TradeApi.Server.Data {
    public static class Seeder {
        private static List<IdentityRole<long>> RoleList = new List<IdentityRole<long>>();
        private static List<Season> Seasons = new List<Season>();

        public static async Task SeedDataAsync(IServiceScope scope, Pd2TradeApiDbContext db) {
            using (var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<long>>>()) {
                await SeedRolesAsync(roleManager);
            }
        }

        private static async Task SeedRolesAsync(RoleManager<IdentityRole<long>> roleManager) {
            RoleList = await roleManager.Roles.ToListAsync();

            foreach (var permission in Enum.GetValues(typeof(AuthorizationPolicyType)).Cast<AuthorizationPolicyType>()) {
                await SeedRoleAsync(roleManager, Enum.GetName(typeof(AuthorizationPolicyType), permission));
            }
        }

        private static async Task SeedRoleAsync(RoleManager<IdentityRole<long>> roleManager, string name) {
            if (!RoleList.Any(r => r.Name == name)) {
                var role = new IdentityRole<long> { Name = name };
                await roleManager.CreateAsync(role);
                RoleList.Add(role);
            }
        }

        private static async Task SeedSeasonsAsync()
        {

            foreach (var season in Enum.GetValues(typeof(Pd2SeasonList)).Cast<Pd2SeasonList>()) {
                
            }
        }
    }
}
