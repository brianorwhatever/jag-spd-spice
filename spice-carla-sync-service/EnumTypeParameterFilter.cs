using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gov.Jag.Spice.CarlaSync
{
    public class EnumTypeParameterFilter : IParameterFilter
    {
        public void Apply(OpenApiParameter parameter, ParameterFilterContext context)
        {
            var type = context.ApiParameterDescription.Type;

            if (type.IsEnum)
            {
                var obj = new OpenApiObject();
                obj["name"] = new OpenApiString(type.Name);
                obj["modelAsString"] = new OpenApiBoolean (false);
                parameter.Extensions.Add("x-ms-enum", obj);
                // parameter.Extensions.Add("x-ms-enum", new { name = type.Name, modelAsString = true });
            }                
        }
    }    
}
