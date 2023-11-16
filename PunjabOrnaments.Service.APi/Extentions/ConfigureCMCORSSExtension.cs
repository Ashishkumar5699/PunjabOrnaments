namespace APIServices.Extentions
{
    public static class ConfigureCMCORSSExtension
    {
        static string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public static IServiceCollection ConfigureCMCORSSetting(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  policy =>
                                  {
                                      policy.WithOrigins("http://localhost:5173/");
                                  });
            });
            return services;
        }
    }
}
        //{
        //    //CORS Setting
        //    // defining policy for CORS
        //    var corsList = Getcorlslist();// configuration.GetSection("AllowedCORS").Get<string[]>();
        //    services.AddCors(options =>
        //    {
        //        options.AddDefaultPolicy(
        //     builder =>
        //     {
        //         builder.WithOrigins(corsList)
        //                             .AllowAnyHeader()
        //                             .AllowAnyMethod();
        //     });
        //    });

        //    return services;
        //}

        //private static string[] Getcorlslist()
        //{
        //    var list = new string[1];
        //    list[0] = "http://localhost:5173";

        //    return list;
        //}
