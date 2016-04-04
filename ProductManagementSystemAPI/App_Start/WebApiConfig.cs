using System;
using System.Configuration;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace ProductManagementSystemAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
                new CamelCasePropertyNamesContractResolver();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "Accounts",
                routeTemplate: "campaigns/factory/new",
                defaults: new { controller = "campaignsfactory", action = "initnew" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "budgets",
                routeTemplate: "campaigns/{campaignId}/budgets",
                defaults: new { controller = "budgets" }
            );

            config.Routes.MapHttpRoute(
                name: "leads",
                routeTemplate: "campaigns/{campaignId}/leads",
                defaults: new { controller = "leads" }
            );

            config.Routes.MapHttpRoute(
                name: "questions",
                routeTemplate: "campaigns/{campaignId}/questions",
                defaults: new { controller = "questions" }
            );
        }
    }
}
