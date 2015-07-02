﻿using System.Web.Mvc;
using Ilaro.Admin.Extensions;

namespace Ilaro.Admin.Areas.IlaroAdmin
{
    public class IlaroAdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "IlaroAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            var prefix = AdminInitialise.RoutesPrefix.IsNullOrWhiteSpace() ?
                "IlaroAdmin" :
                AdminInitialise.RoutesPrefix;

            context.MapRoute(
                name: "IlaroAdminResources",
                url: "ira/{action}/{id}",
                defaults: new { controller = "Resource" },
                namespaces: new[] { "Ilaro.Admin.Areas.IlaroAdmin.Controllers" }
            );

            context.MapRoute(
                name: "IlaroAdmin_Logout",
                url: prefix + "/Logout",
                defaults: new { controller = "Account", action = "Logout" },
                namespaces: new[] { "Ilaro.Admin.Areas.IlaroAdmin.Controllers" }
            );

            context.MapRoute(
                name: "IlaroAdmin_EntityCreate",
                url: prefix + "/{entityName}/Create",
                defaults: new { controller = "Entity", action = "Create" },
                namespaces: new[] { "Ilaro.Admin.Areas.IlaroAdmin.Controllers" }
            );

            context.MapRoute(
                name: "IlaroAdmin_EntityEdit",
                url: prefix + "/{entityName}/Edit/{key}",
                defaults: new { controller = "Entity", action = "Edit" },
                namespaces: new[] { "Ilaro.Admin.Areas.IlaroAdmin.Controllers" }
            );

            context.MapRoute(
                name: "IlaroAdmin_EntityDelete",
                url: prefix + "/{entityName}/Delete/{key}",
                defaults: new { controller = "Entity", action = "Delete" },
                namespaces: new[] { "Ilaro.Admin.Areas.IlaroAdmin.Controllers" }
            );

            context.MapRoute(
                name: "IlaroAdmin_EntitiesChanges",
                url: prefix + "/{entityName}/Changes/{page}",
                defaults: new { controller = "Entities", action = "Changes", page = 1 },
                namespaces: new[] { "Ilaro.Admin.Areas.IlaroAdmin.Controllers" }
            );

            context.MapRoute(
                name: "IlaroAdmin_Entities",
                url: prefix + "/{entityName}/{page}",
                defaults: new { controller = "Entities", action = "Index", page = 1 },
                namespaces: new[] { "Ilaro.Admin.Areas.IlaroAdmin.Controllers" }
            );

            context.MapRoute(
                name: "IlaroAdmin_EntitiesGroup",
                url: prefix + "/{groupName}/Group",
                defaults: new { controller = "Group", action = "Details" },
                namespaces: new[] { "Ilaro.Admin.Areas.IlaroAdmin.Controllers" }
            );

            context.MapRoute(
                name: "IlaroAdmin_Default",
                url: prefix + "/{controller}/{action}/{id}",
                defaults: new { controller = "Group", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Ilaro.Admin.Areas.IlaroAdmin.Controllers" }
            );
        }
    }
}
