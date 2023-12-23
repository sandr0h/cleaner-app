using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cleaner.Core.Services;
using Cleaner.Core.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace cleaner_app
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<MainForm>();

            services.AddSingleton<ICleanService, CleanService>();
            services.AddSingleton<IMessageQueueService, MessageQueueService>();
        }
    }
}
