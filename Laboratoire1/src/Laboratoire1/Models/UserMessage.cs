using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratoire1.Models
{
    public class UserMessage : IRouteConstraint
    {
        public enum _type {
            ERROR,
            SUCCESS
        }
        public _type type { get; set; }
        public string m_message { get; set; }
        public UserMessage(string p_message, _type type) {
            this.m_message = p_message;
            this.type = type;
        }
        public UserMessage() {
        }

        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            object value;
            if (values.TryGetValue("m_message", out value) && value != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
