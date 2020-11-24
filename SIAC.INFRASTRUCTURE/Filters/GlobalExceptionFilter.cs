using SIAC.CORE.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;

namespace SIAC.INFRASTRUCTURE.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            //verificamos que el contexto y al excepcion sean iguales.
            if(context.Exception.GetType() == typeof(GlobalException))
            {
                //Obtenemos la excepción.
                var exp = (GlobalException)context.Exception;

                //Dependiendo del codigo se valida se retorna el tipo de excepcion.
                //Creamos una estructura.
                Object estructura = null;

                #region validations
                if(exp.Codigo == (int)HttpStatusCode.NotFound) ////Cuando no se encuentran registros
                {
                    estructura = new
                    {
                        Title = "Data not found",
                        Details = "Data not found in the request.",
                        Code = exp.Codigo
                    };
                }

                if (exp.Codigo == (int)HttpStatusCode.BadRequest) ////Cuando no se encuentran registros
                {
                    estructura = new
                    {
                        Title = "Bad request",
                        Details = exp.Message,
                        Code = exp.Codigo
                    };
                }

                if (exp.Codigo == (int)HttpStatusCode.InternalServerError) ////Cuando no se encuentran registros
                {
                    estructura = new
                    {
                        Title = "Internal Server Error",
                        Details = exp.Message,
                        Code = exp.Codigo
                    };
                }
                #endregion

                //Creamos el JSON en la estructura.
                var json = new
                {
                    Errors = new[] { estructura }
                };

                //Devolvemos el JSON generado
                // context.Result =  ObjectResult(json);
                context.Result = new ObjectResult(json);
                context.HttpContext.Response.StatusCode = exp.Codigo;
                context.ExceptionHandled = true;

            }
        }
    }
}
