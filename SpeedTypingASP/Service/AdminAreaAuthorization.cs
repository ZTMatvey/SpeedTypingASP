using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace SpeedTypingASP.Service
{
    public class AdminAreaAuthorization : IControllerModelConvention
    {
        private readonly string area;
        private readonly string policy;

        public AdminAreaAuthorization(string area, string policy)
        {
            this.area = area;
            this.policy = policy;
        }
        public void Apply(ControllerModel controller)
        {
            var attributeAreaAny = controller.Attributes.Any(
                    a => a is AreaAttribute attribute &&
                         attribute.RouteValue.Equals(area, StringComparison.OrdinalIgnoreCase));
            var routeValueExistsAny = controller.RouteValues.Any(
                v=> v.Key.Equals("area", StringComparison.OrdinalIgnoreCase) &&
                    v.Value.Equals(area, StringComparison.OrdinalIgnoreCase));
            if (attributeAreaAny || routeValueExistsAny)
                controller.Filters.Add(new AuthorizeFilter(policy));

        }
    }
}
