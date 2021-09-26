using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AreasWS
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class Calculo : System.Web.Services.WebService
    {
        [WebMethod]
        public decimal Cuadrado(decimal lado)
        {
            Calculos c = new Calculos();
            return c.Cuadrado(lado);
        }


        [WebMethod]
        public decimal Triangulo (decimal lado, decimal altura)
        {
            Calculos c = new Calculos();
            return c.Triangulo(lado, altura);
        }

        [WebMethod]
        public decimal Circulo(decimal radio)
        {
            Calculos c = new Calculos();
            return c.Circulo(radio);
        }
    }
}
