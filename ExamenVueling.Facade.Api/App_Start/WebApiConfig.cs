﻿using ExamenVueling.Facade.Api.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ExamenVueling.Facade.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            // Nuevo
            config.MessageHandlers.Add(new TokenValidate());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
