using API_SurveillenceCommerciale.Context;
using API_SurveillenceCommerciale.Repository;
using API_SurveillenceCommerciale.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Xml;

namespace API_SurveillenceCommerciale
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public object RegitrationStrategy { get; private set; }

        public static string Serveur = "(local)";
        public static string Db = "I2S_PVAzur";
        public static string Usr = "sa";
        public static string Pwd = "ideal2s";
        private void Charger_Configuration()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(System.AppDomain.CurrentDomain.BaseDirectory + "\\Config.xml");
            XmlNode child = doc.SelectSingleNode("/Configurations");
            foreach (System.Xml.XmlNode n in child)
                if (n.Attributes["id"].Value == "x")
                {
                    for (int i = 0; i < n.ChildNodes.Count; i++)

                        switch (n.ChildNodes[i].Name)
                        {
                            case "Serveur":
                                Serveur = n.ChildNodes[i].InnerText;
                                break;
                            case "Db":
                                Db = n.ChildNodes[i].InnerText;
                                break;

                            case "Usr":
                                Usr = n.ChildNodes[i].InnerText;
                                break;
                            case "Pwd":
                                Pwd = n.ChildNodes[i].InnerText;

                                break;
                        }
                }

        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            Charger_Configuration();

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder
                .WithOrigins("http://0.0.0.0:7068")
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
            try
            {
                services.AddDbContext<AppDBContext>(Options =>
                {
                    Options.UseSqlServer("server=" + Serveur + ";database=" + Db + ";integrated security=false;user id=" + Usr + ";password=" + Pwd + ";");
                });
            }
            catch { }
            services.AddControllers();
            services.AddSignalR();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RestFullAPI", Version = "v1" });
                c.IgnoreObsoleteActions();
                c.IgnoreObsoleteProperties();

                // Configuration de l'authentification Swagger




            });


           
            
            #region Ajouter les INTERFACES REPOSITORY
            services.AddScoped<ISessionJoursRepository,SessionJourRepository >();
           
            #endregion

        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "RestFullAPI V1");
                // Afficher le bouton "Authorize"
                c.DisplayRequestDuration();
                c.EnableFilter();
                c.EnableValidator();
                c.ShowExtensions();
                c.EnableDeepLinking();
                c.DisplayOperationId();
                c.EnableFilter();

                c.EnableValidator();
                c.ShowExtensions();
                c.EnableDeepLinking();
                c.DisplayOperationId();
                c.EnableFilter();

                c.EnableValidator();
                c.ShowExtensions();
                c.EnableDeepLinking();
                c.DisplayOperationId();
            });

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors("CorsPolicy");
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

}

