﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace rest_06_jwt.Models
{
    public class AutorizzaUtentePerTipo : Attribute,IAuthorizationFilter
    {
        private readonly string _tipologiaUtenteRichiesta;
        public AutorizzaUtentePerTipo(string tipoUtente)
        {
            _tipologiaUtenteRichiesta = tipoUtente;
        }
        
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var claims = context.HttpContext.User.Claims;

            var userType = claims.FirstOrDefault(c => c.Type == "userType")?.Value;

            
                // deve dare forbidden ossia non autorizzato

                if (userType is null || userType != _tipologiaUtenteRichiesta)
                {
                    context.Result = new StatusCodeResult(StatusCodes.Status403Forbidden);
                }
        }
    }
}
