using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace DemoIX
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            /**
                *Configuración y servicios de API web
                En esta sección se realizar una limpieza del formato por defecto de la aplicación
                con Formatters.Clear() y luego procedemos a asignar un nuevo formato por defecto
                a nuestra aplicación el cual sería JSON
            */
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
