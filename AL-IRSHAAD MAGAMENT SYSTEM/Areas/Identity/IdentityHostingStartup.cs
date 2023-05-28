using System;
using AL_IRSHAAD_MAGAMENT_SYSTEM.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AL_IRSHAAD_MAGAMENT_SYSTEM.Areas.Identity.IdentityHostingStartup))]
namespace AL_IRSHAAD_MAGAMENT_SYSTEM.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}