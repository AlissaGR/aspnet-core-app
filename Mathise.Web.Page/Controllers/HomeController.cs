using System.Diagnostics;
using Mathise.Web.Page.Models;
using Microsoft.AspNetCore.Mvc;


namespace Mathise.Web.Page.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly List<Producto> _productos;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _productos = new List<Producto>
        {
            new Producto
            {
                Id = "B001",
                Nombre = "SHEIN Privé Camiseta con estampado floral de un hombro de manga farol",
                Categoria = "Blusas",
                Precio = 28.00m,
                PrecioAnterior = 35.00m,
                Descuento = 20,
                Descripcion = "SHEIN Privé Camiseta con estampado floral de un hombro de manga farol",
                Color = new List<string> { "Blanco" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa1.png",
                    "~/images/Blusas/Blusa1-1.png",
                    "~/images/Blusas/Blusa1-2.png",
                    "~/images/Blusas/Blusa1-3.png",
                    "~/images/Blusas/Blusa1-4.png"
                }
            },
            new Producto
            {
                Id = "B002",
                Nombre = "SHEIN Frenchy Camiseta de cuello cruzado manga de campana",
                Categoria = "Blusas",
                Precio = 35.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Albaricoque" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa2.png",
                    "~/images/Blusas/Blusa2-1.png",
                    "~/images/Blusas/Blusa2-2.png",
                    "~/images/Blusas/Blusa2-3.png",
                    "~/images/Blusas/Blusa2-4.png"
                }
            },
            new Producto
            {
                Id = "B003",
                Nombre = "SHEIN Privé Camiseta con estampado geométrico de hombros descubiertos",
                Categoria = "Blusas",
                Precio = 27.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa3.png",
                    "~/images/Blusas/Blusa3-1.png",
                    "~/images/Blusas/Blusa3-2.png",
                    "~/images/Blusas/Blusa3-3.png",
                    "~/images/Blusas/Blusa3-4.png"
                }
            },
            new Producto
            {
                Id = "B004",
                Nombre = "SHEIN Privé Camiseta con estampado geométrico con abertura delantera",
                Categoria = "Blusas",
                Precio = 27.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "XL" },
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa4.png",
                    "~/images/Blusas/Blusa4-1.png",
                    "~/images/Blusas/Blusa4-2.png",
                    "~/images/Blusas/Blusa4-3.png",
                    "~/images/Blusas/Blusa4-4.png"
                }
            },
            new Producto
            {
                Id = "B005",
                Nombre = "SHEIN Camiseta negra con rayas blancas de cuello alto",
                Categoria = "Blusas",
                Precio = 23.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa5.png",
                    "~/images/Blusas/Blusa5-1.png",
                    "~/images/Blusas/Blusa5-2.png",
                    "~/images/Blusas/Blusa5-3.png",
                    "~/images/Blusas/Blusa5-4.png"
                }
            },
            new Producto
            {
                Id = "B006",
                Nombre = "SHEIN Blusa holgada de mujer manga corta con estampado minimalista de rostro",
                Categoria = "Blusas",
                Precio = 25.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "M"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa6.png",
                    "~/images/Blusas/Blusa6-1.png",
                    "~/images/Blusas/Blusa6-2.png",
                    "~/images/Blusas/Blusa6-3.png",
                    "~/images/Blusas/Blusa6-4.png"
                }
            },
            new Producto
            {
                Id = "B007",
                Nombre = "SHEIN LUNE Blusa Sin Mangas Con Estampado Floral Y Escote En V",
                Categoria = "Blusas",
                Precio = 33.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Beige" },
                Talla = new List<string> { "XL" },
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa7.png",
                    "~/images/Blusas/Blusa7-1.png",
                    "~/images/Blusas/Blusa7-2.png",
                    "~/images/Blusas/Blusa7-3.png",
                    "~/images/Blusas/Blusa7-4.png"
                }
            },
            new Producto
            {
                Id ="B008",
                Nombre = "SHEIN LUNE Camisa para mujer estampada de corte aleatorio",
                Categoria = "Blusas",
                Precio = 22.00m,
                PrecioAnterior = 37.00m,
                Descuento = 20,
                Color = new List<string> { "Celeste" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa8.png",
                    "~/images/Blusas/Blusa8-1.png",
                    "~/images/Blusas/Blusa8-2.png",
                    "~/images/Blusas/Blusa8-3.png",
                    "~/images/Blusas/Blusa8-4.png"
                }
            },
            new Producto
            {
                Id = "B009",
                Nombre = "SHEIN LUNE Camiseta gráfica casual de verano de punto con estampado jacquard para mujeres",
                Categoria = "Blusas",
                Precio = 17.00m,
                PrecioAnterior = 33.00m,
                Descuento = 25,
                Color = new List<string> { "Fucsia" },
                Talla = new List<string> { "M"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa9.png",
                    "~/images/Blusas/Blusa9-1.png",
                    "~/images/Blusas/Blusa9-2.png",
                    "~/images/Blusas/Blusa9-3.png",
                    "~/images/Blusas/Blusa9-4.png"
                }
            },
            new Producto
            {
                Id = "B0010",
                Nombre = "SHEIN BAE Top de tirantes crop con fruncido delantero fruncido",
                Categoria = "Blusas",
                Precio = 15.00m,
                PrecioAnterior = 27.00m,
                Descuento = 20,
                Color = new List<string> { "Azul" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                   "~/images/Blusas/Blusa10.png",
                    "~/images/Blusas/Blusa10-1.png",
                    "~/images/Blusas/Blusa10-2.png",
                    "~/images/Blusas/Blusa10-3.png",
                    "~/images/Blusas/Blusa10-4.png"
                }
            },
            new Producto
            {
                Id = "B0011",
                Nombre = "SHEIN Allurite Camiseta de hombros fruncido",
                Categoria = "Blusas",
                Precio = 33.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Azul Marino" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa11.png",
                    "~/images/Blusas/Blusa11-1.png",
                    "~/images/Blusas/Blusa11-2.png",
                    "~/images/Blusas/Blusa11-3.png",
                    "~/images/Blusas/Blusa11-4.png"
                }
            },
            new Producto
            {
                Id = "B0012",
                Nombre = "SHEIN Frenchy Blusa de mujer con escote en V, mangas con volantes y estampado floral y de olas, estilo \"Old Money\"",
                Categoria = "Blusas",
                Precio = 25.00m,
                PrecioAnterior = 37.00m,
                Descuento = 20,
                Color = new List<string> { "Rosado" },
                Talla = new List<string> { "M"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa12.png",
                    "~/images/Blusas/Blusa12-1.png",
                    "~/images/Blusas/Blusa12-2.png",
                    "~/images/Blusas/Blusa12-3.png",
                    "~/images/Blusas/Blusa12-4.png"
                }
            },

            new Producto
            {
                Id = "B0013",
                Nombre = "SHEIN Frenchy Camisa De Manga Mariposa Con Lazo En La Espalda Y Estampado Completo",
                Categoria = "Blusas",
                Precio = 31.00m,
                //PrecioAnterior = 37.00m,
                //Descuento = 20,
                Color = new List<string> { "Multicolor" },
                Talla = new List<string> { "L"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa13.png",
                    "~/images/Blusas/Blusa13-1.png",
                    "~/images/Blusas/Blusa13-2.png",
                    "~/images/Blusas/Blusa13-3.png",
                    "~/images/Blusas/Blusa13-4.png"
                }
            },

            new Producto
            {
                Id = "B0014",
                Nombre = "SHEIN Frenchy Top de tirantes con encaje y estampado floral",
                Categoria = "Blusas",
                Precio = 15.00m,
                PrecioAnterior = 27.00m,
                Descuento = 20,
                Color = new List<string> { "Blanco" },
                Talla = new List<string> { "S"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa14.png",
                    "~/images/Blusas/Blusa14-1.png",
                    "~/images/Blusas/Blusa14-2.png",
                    "~/images/Blusas/Blusa14-3.png",
                    "~/images/Blusas/Blusa14-4.png"
                }
            },

            new Producto
            {
                Id = "B0015",
                Nombre = "SHEIN Frenchy Camisa Casual De Mujer Sin Mangas De Longitud Media Con Estampado Floral",
                Categoria = "Blusas",
                Precio = 17.00m,
                PrecioAnterior = 37.00m,
                Descuento = 20,
                Color = new List<string> { "Beige" },
                Talla = new List<string> { "S"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa15.png",
                    "~/images/Blusas/Blusa15-1.png",
                    "~/images/Blusas/Blusa15-2.png",
                    "~/images/Blusas/Blusa15-3.png",
                    "~/images/Blusas/Blusa15-4.png"
                }
            },

            new Producto
            {
                Id = "B0016",
                Nombre = "SHEIN VaVaLuxe Camiseta de mujer de verano con cuello simulado de volantes y estampado de leopardo",
                Categoria = "Blusas",
                Precio = 25.00m,
                //PrecioAnterior = 37.00m,
                //Descuento = 20,
                Color = new List<string> { "Beige" },
                Talla = new List<string> { "S"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa16.png",
                    "~/images/Blusas/Blusa16-1.png",
                    "~/images/Blusas/Blusa16-2.png",
                    "~/images/Blusas/Blusa16-3.png",
                    "~/images/Blusas/Blusa16-4.png"
                }
            },

            new Producto
            {
                Id = "B0017",
                Nombre = "SHEIN VaVaLuxe Camiseta casual de verano para mujer con cuello alto, manga corta y plisada con estampado floral",
                Categoria = "Blusas",
                Precio = 29.00m,
                //PrecioAnterior = 37.00m,
                //Descuento = 20,
                Color = new List<string> { "Beige" },
                Talla = new List<string> { "XL"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa17.png",
                    "~/images/Blusas/Blusa17-1.png",
                    "~/images/Blusas/Blusa17-2.png",
                    "~/images/Blusas/Blusa17-3.png",
                    "~/images/Blusas/Blusa17-4.png"
                }
            },

            new Producto
            {
                Id = "B0018",
                Nombre = "SHEIN VCAY Blusa cruzada de manga corta con escote en V y estampado integral",
                Categoria = "Blusas",
                Precio = 26.00m,
                //PrecioAnterior = 37.00m,
                //Descuento = 20,
                Color = new List<string> { "Rosado" },
                Talla = new List<string> { "S"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa18.png",
                    "~/images/Blusas/Blusa18-1.png",
                    "~/images/Blusas/Blusa18-2.png",
                    "~/images/Blusas/Blusa18-3.png",
                    "~/images/Blusas/Blusa18-4.png"
                }
            },

            new Producto
            {
                Id = "B0019",
                Nombre = "SHEIN Privé Camiseta con estampado de pata de gallo escote corazón de manga farol",
                Categoria = "Blusas",
                Precio = 27.00m,
                //PrecioAnterior = 37.00m,
                //Descuento = 20,
                Color = new List<string> { "Blanco" },
                Talla = new List<string> { "S"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa19.png",
                    "~/images/Blusas/Blusa19-1.png",
                    "~/images/Blusas/Blusa19-2.png",
                    "~/images/Blusas/Blusa19-3.png",
                    "~/images/Blusas/Blusa19-4.png"
                }
            },

            new Producto
            {
                Id = "B0020",
                Nombre = "SHEIN PETITE 2 piezas Camiseta de mujer de primavera con cuello de pico sólido",
                Categoria = "Blusas",
                Precio = 37.00m,
                //PrecioAnterior = 37.00m,
                //Descuento = 20,
                Color = new List<string> { "Blanco y Negro" },
                Talla = new List<string> { "L"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa20.png",
                    "~/images/Blusas/Blusa20-1.png",
                    "~/images/Blusas/Blusa20-2.png",
                    "~/images/Blusas/Blusa20-3.png",
                    "~/images/Blusas/Blusa20-4.png"
                }
            },

            new Producto
            {
                Id = "B0021",
                Nombre = "SHEIN LUNE Camiseta Sin Mangas De Mujer Con Estampado De Letras Y Corazones",
                Categoria = "Blusas",
                Precio = 10.00m,
                PrecioAnterior = 25.00m,
                Descuento = 20,
                Color = new List<string> { "Gris" },
                Talla = new List<string> { "S"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa21.png",
                    "~/images/Blusas/Blusa21-1.png",
                    "~/images/Blusas/Blusa21-2.png",
                    "~/images/Blusas/Blusa21-3.png",
                    "~/images/Blusas/Blusa21-4.png"
                }
            },

            new Producto
            {
                Id = "B0022",
                Nombre = "SHEIN LUNE Camiseta básica de manga corta y escote redondo para mujer, ideal para festivales de música en verano",
                Categoria = "Blusas",
                Precio = 16.00m,
                PrecioAnterior = 25.00m,
                Descuento = 20,
                Color = new List<string> { "Gris" },
                Talla = new List<string> { "M","L"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa22.png",
                    "~/images/Blusas/Blusa22-1.png",
                    "~/images/Blusas/Blusa22-2.png",
                    "~/images/Blusas/Blusa22-3.png",
                    "~/images/Blusas/Blusa22-4.png"
                }
            },

            new Producto
            {
                Id = "B0023",
                Nombre = "SHEIN Essnce Chaleco de punto asimétrico para mujer",
                Categoria = "Blusas",
                Precio = 10.00m,
                PrecioAnterior = 22.00m,
                Descuento = 20,
                Color = new List<string> { "Beige" },
                Talla = new List<string> { "M"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa23.png",
                    "~/images/Blusas/Blusa23-1.png",
                    "~/images/Blusas/Blusa23-2.png",
                    "~/images/Blusas/Blusa23-3.png",
                    "~/images/Blusas/Blusa23-4.png"
                }
            },

            new Producto
            {
                Id = "B0024",
                Nombre = "SHEIN Essnce Camiseta de cuello alto sin mangas de unicolor, minimalista, para uso casual diario",
                Categoria = "Blusas",
                Precio = 17.00m,
                //PrecioAnterior = 37.00m,
                //Descuento = 20,
                Color = new List<string> { "Lila" },
                Talla = new List<string> { "XS","S"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa24.png",
                    "~/images/Blusas/Blusa24-1.png",
                    "~/images/Blusas/Blusa24-2.png",
                    "~/images/Blusas/Blusa24-3.png",
                    "~/images/Blusas/Blusa24-4.png"
                }
            },

            new Producto
            {
                Id = "B0025",
                Nombre = "EMERY ROSE Ropa de otoño Camisetas básicas para mujeres Parte superior con estampado de leopardo",
                Categoria = "Blusas",
                Precio = 27.00m,
                //PrecioAnterior = 37.00m,
                //Descuento = 20,
                Color = new List<string> { "Beige" },
                Talla = new List<string> { "M"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa25.png",
                    "~/images/Blusas/Blusa25-1.png",
                    "~/images/Blusas/Blusa25-2.png",
                    "~/images/Blusas/Blusa25-3.png",
                    "~/images/Blusas/Blusa25-4.png"
                }
            },

            new Producto
            {
                Id = "B0026",
                Nombre = "Dazy Star Camiseta De Manga Corta Sólida Para Ajuste Estrecho Con Cierre De Botones Frontales",
                Categoria = "Blusas",
                Precio = 20.00m,
                //PrecioAnterior = 37.00m,
                //Descuento = 20,
                Color = new List<string> { "Gris" },
                Talla = new List<string> { "S"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa26.png",
                    "~/images/Blusas/Blusa26-1.png",
                    "~/images/Blusas/Blusa26-2.png",
                    "~/images/Blusas/Blusa26-3.png",
                    "~/images/Blusas/Blusa26-4.png"
                }
            },

            new Producto
            {
                Id = "B0027",
                Nombre = "DAZY Camiseta de mujer de verano casual con unicolor, cuello asimétrico y plisada",
                Categoria = "Blusas",
                Precio = 23.00m,
                //PrecioAnterior = 37.00m,
                //Descuento = 20,
                Color = new List<string> { "Blanco" },
                Talla = new List<string> { "S"},
                Imagenes = new List<string>
                {
                    "~/images/Blusas/Blusa27.png",
                    "~/images/Blusas/Blusa27-1.png",
                    "~/images/Blusas/Blusa27-2.png",
                    "~/images/Blusas/Blusa27-3.png",
                    "~/images/Blusas/Blusa27-4.png"
                }
            },

            

            // Pantalones...

            new Producto
            {
                Id = "P001",
                Nombre = "SHEIN Essnce Jean negro ajustado con bolsillos oblicuos",
                Categoria = "Pantalones",
                Precio = 65.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Pantalones/P001.png",
                    "~/images/Pantalones/P001-1.png",
                    "~/images/Pantalones/P001-2.png",
                    "~/images/Pantalones/P001-3.png",
                    "~/images/Pantalones/P001-4.png"
                }
            },
            new Producto
            {
                Id = "P002",
                Nombre = "SHEIN MOOSTA Pantalon casual de mujer negro con ajuste ceñido",
                Categoria = "Pantalones",
                Precio = 68.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Pantalones/P002.png",
                    "~/images/Pantalones/P002-1.png",
                    "~/images/Pantalones/P002-2.png",
                    "~/images/Pantalones/P002-3.png",
                    "~/images/Pantalones/P002-4.png"
                }
            },
             new Producto
            {
                Id = "P003",
                Nombre = "SHEIN Essnce Jeans Azul informales ajustados para mujer con bolsillos, versátiles",
                Categoria = "Pantalones",
                Precio = 70.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Azul" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Pantalones/P003.png",
                    "~/images/Pantalones/P003-1.png",
                    "~/images/Pantalones/P003-2.png",
                    "~/images/Pantalones/P003-3.png",
                    "~/images/Pantalones/P003-4.png"
                }
            },
              new Producto
            {
                Id = "P004",
                Nombre = "SHEIN Pantalon Jean negro simple y ajustados para uso diario con tobillos estrechos",
                Categoria = "Pantalones",
                Precio = 68.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Pantalones/P004.png",
                    "~/images/Pantalones/P004-1.png",
                    "~/images/Pantalones/P004-2.png",
                    "~/images/Pantalones/P004-3.png",
                    "~/images/Pantalones/P004-4.png"
                }
            },
                new Producto
            {
                Id = "P005",
                Nombre = "SHEIN Essnce Pantalones vaqueros ajustados informales de denim elástico con bolsillos",
                Categoria = "Pantalones",
                Precio = 50.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Pantalones/P005.png",
                    "~/images/Pantalones/P005-1.png",
                    "~/images/Pantalones/P005-2.png",
                    "~/images/Pantalones/P005-3.png",
                    "~/images/Pantalones/P005-4.png"
                }
            },
                  new Producto
            {
                Id = "P006",
                Nombre = "SHEIN Pantalones negros casuales con aplicaciones brillantes, pantalones negros elegantes",
                Categoria = "Pantalones",
                Precio = 45.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "XL" },
                Imagenes = new List<string>
                {
                    "~/images/Pantalones/P006.png",
                    "~/images/Pantalones/P006-1.png",
                    "~/images/Pantalones/P006-2.png",
                    "~/images/Pantalones/P006-3.png",
                    "~/images/Pantalones/P006-4.png"
                }
            },
                    new Producto
            {
                Id = "P007",
                Nombre = "SHEIN EZwear Pantalón de chándal estilo retro con pierna de campana y cintura con lazo",
                Categoria = "Pantalones",
                Precio = 35.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Camel" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Pantalones/P007.png",
                    "~/images/Pantalones/P007-1.png",
                    "~/images/Pantalones/P007-2.png",
                    "~/images/Pantalones/P007-3.png",
                    "~/images/Pantalones/P007-4.png"
                }
            },
              new Producto
            {
                Id = "P008",
                Nombre = "SHEIN SXY Jeans casuales versátiles de mujer con bolsillos y desgastados, tipo skinny",
                Categoria = "Pantalones",
                Precio = 55.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Celeste" },
                Talla = new List<string> { "28","30","32" },
                Imagenes = new List<string>
                {
                    "~/images/Pantalones/P008.png",
                    "~/images/Pantalones/P008-1.png",
                    "~/images/Pantalones/P008-2.png",
                    "~/images/Pantalones/P008-3.png",
                    "~/images/Pantalones/P008-4.png"
                }
            },
             new Producto
            {
                Id = "P009",
                Nombre = "SHEIN SXY Jeans casuales de mezclilla versátiles y ajustados con bolsillos para mujer",
                Categoria = "Pantalones",
                Precio = 57.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Gris" },
                Talla = new List<string> { "34" },
                Imagenes = new List<string>
                {
                    "~/images/Pantalones/P009.png",
                    "~/images/Pantalones/P009-1.png",
                    "~/images/Pantalones/P009-2.png",
                    "~/images/Pantalones/P009-3.png",
                    "~/images/Pantalones/P009-4.png"
                }
            },
             new Producto
            {
                Id = "P010",
                Nombre = "SHEIN Pantalones con paneles de tela de malla, leggings acampanados con control de abdomen y levantamiento de glúteos",
                Categoria = "Pantalones",
                Precio = 30.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Pantalones/P010.png",
                    "~/images/Pantalones/P010-1.png",
                    "~/images/Pantalones/P010-2.png",
                    "~/images/Pantalones/P010-3.png",
                    "~/images/Pantalones/P010-4.png"
                }
            },
                            new Producto
            {
                Id = "P011",
                Nombre = "SHEIN EZwear Jeans acampanados con bolsillos diagonales lavados de estilo casual",
                Categoria = "Pantalones",
                Precio = 60.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Azul" },
                Talla = new List<string> { "28" },
                Imagenes = new List<string>
                {
                    "~/images/Pantalones/P011.png",
                    "~/images/Pantalones/P011-1.png",
                    "~/images/Pantalones/P011-2.png",
                    "~/images/Pantalones/P011-3.png",
                    "~/images/Pantalones/P011-4.png"
                }
            },
                              new Producto
            {
                Id = "P012",
                Nombre = "SHEIN Essnce Pantalones de moda de pierna acampanada",
                Categoria = "Pantalones",
                Precio = 25.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Fucsia" },
                Talla = new List<string> { "M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Pantalones/P012.png",
                    "~/images/Pantalones/P012-1.png",
                    "~/images/Pantalones/P012-2.png",
                    "~/images/Pantalones/P012-3.png",
                    "~/images/Pantalones/P012-4.png"
                }
            },
                                new Producto
            {
                Id = "P013",
                Nombre = "SHEIN Pantalones casuales ceñidos de botones lisos para mujer",
                Categoria = "Pantalones",
                Precio = 55.00m,
                //PrecioAnterior = 60.00m,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "XS","M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Pantalones/P013.png",
                    "~/images/Pantalones/P013-1.png",
                    "~/images/Pantalones/P013-2.png",
                    "~/images/Pantalones/P013-3.png",
                    "~/images/Pantalones/P013-4.png"
                }
            },


            // Casacas...

            new Producto
            {
                Id = "C001",
                Nombre = "SHEIN MISSGUIDED Chaqueta varsity con logo bordado",
                Categoria = "Casacas",
                Precio = 60.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C001.png",
                    "~/images/Casacas/C001-1.png",
                    "~/images/Casacas/C001-2.png",
                    "~/images/Casacas/C001-3.png",
                    "~/images/Casacas/C001-4.png"
                }
            },

            new Producto
            {
                Id = "C002",
                Nombre = "SHEIN MISSGUIDED Chaqueta acolchada de manga larga con cremallera y cuello de contraste",
                Categoria = "Casacas",
                Precio = 60.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Vino" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C002.png",
                    "~/images/Casacas/C002-1.png",
                    "~/images/Casacas/C002-2.png",
                    "~/images/Casacas/C002-3.png",
                    "~/images/Casacas/C002-4.png"
                }
            },
            new Producto
            {
                Id = "C003",
                Nombre = "SHEIN SUMWON WOMEN Chaqueta tipo camionero corta con cristales desgastados y detalles de cadena",
                Categoria = "Casacas",
                Precio = 65.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Azul" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C003.png",
                    "~/images/Casacas/C003-1.png",
                    "~/images/Casacas/C003-2.png",
                    "~/images/Casacas/C003-3.png",
                    "~/images/Casacas/C003-4.png"
                }
            },
            new Producto
            {
                Id = "C004",
                Nombre = "SHEIN SUMWON WOMEN Chaleco oversize acolchado tipo puffer sin mangas con cierre",
                Categoria = "Casacas",
                Precio = 50.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "XS" },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C004.png",
                    "~/images/Casacas/C004-1.png",
                    "~/images/Casacas/C004-2.png",
                    "~/images/Casacas/C004-3.png",
                    "~/images/Casacas/C004-4.png"
                }
            },
            new Producto
            {
                Id = "C005",
                Nombre = "SHEIN SXY Cazadora crop con diseño de solapa",
                Categoria = "Casacas",
                Precio = 60.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C005.png",
                    "~/images/Casacas/C005-1.png",
                    "~/images/Casacas/C005-2.png",
                    "~/images/Casacas/C005-3.png",
                    "~/images/Casacas/C005-4.png"
                }
            },
            new Producto
            {
                Id = "C006",
                Nombre = "SHEIN Aloruh Chaqueta versátil de retazos de piel para otoño e invierno, a prueba de viento",
                Categoria = "Casacas",
                Precio = 75.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Beige" },
                Talla = new List<string> { "S","M" },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C006.png",
                    "~/images/Casacas/C006-1.png",
                    "~/images/Casacas/C006-2.png",
                    "~/images/Casacas/C006-3.png",
                    "~/images/Casacas/C006-4.png"
                }
            },
            new Producto
            {
                Id = "C007",
                Nombre = "SHEIN LUNE Chaqueta de pana con bolsillos de solapa",
                Categoria = "Casacas",
                Precio = 55.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Caqui" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C007.png",
                    "~/images/Casacas/C007-1.png",
                    "~/images/Casacas/C007-2.png",
                    "~/images/Casacas/C007-3.png",
                    "~/images/Casacas/C007-4.png"
                }
            },
            new Producto
            {
                Id = "C008",
                Nombre = "SHEIN AiiRZ Chaqueta bomber corta de cuello alto de denim",
                Categoria = "Casacas",
                Precio = 60.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Azul" },
                Talla = new List<string> { "S","M","L"  },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C008.png",
                    "~/images/Casacas/C008-1.png",
                    "~/images/Casacas/C008-2.png",
                    "~/images/Casacas/C008-3.png",
                    "~/images/Casacas/C008-4.png"
                }
            },
            new Producto
            {
                Id = "C009",
                Nombre = "SHEIN EZwear Chaqueta corta informal con estampado de leopardo",
                Categoria = "Casacas",
                Precio = 48.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Leopardo" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C009.png",
                    "~/images/Casacas/C009-1.png",
                    "~/images/Casacas/C009-2.png",
                    "~/images/Casacas/C009-3.png",
                    "~/images/Casacas/C009-4.png"
                }
            },
            new Producto
            {
                Id = "C010",
                Nombre = "SHEIN ROMWE Cárdigan de cuello alto con doble cremallera ajustado a rayas estilo vintage",
                Categoria = "Casacas",
                Precio = 37.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Azul" },
                Talla = new List<string> { "S","M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C010.png",
                    "~/images/Casacas/C010-1.png",
                    "~/images/Casacas/C010-2.png",
                    "~/images/Casacas/C010-3.png",
                    "~/images/Casacas/C010-4.png"
                }
            },
            new Producto
            {
                Id = "C011",
                Nombre = "SHEIN ROMWE Chaqueta con estampado de leopardo esponjoso y bordado de estrella vintage",
                Categoria = "Casacas",
                Precio = 37.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Leopardo" },
                Talla = new List<string> { "S","M","L"  },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C011.png",
                    "~/images/Casacas/C011-1.png",
                    "~/images/Casacas/C011-2.png",
                    "~/images/Casacas/C011-3.png",
                    "~/images/Casacas/C011-4.png"
                }
            },
            new Producto
            {
                Id = "C012",
                Nombre = "SHEIN VARSITIE básico de yoga deportivo con top de manga larga",
                Categoria = "Casacas",
                Precio = 27.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C012.png",
                    "~/images/Casacas/C012-1.png",
                    "~/images/Casacas/C012-2.png",
                    "~/images/Casacas/C012-3.png",
                    "~/images/Casacas/C012-4.png"
                }
            },
            new Producto
            {
                Id = "C013",
                Nombre = "SHEIN Chaqueta de mezclilla corta de manga larga y abotonadura",
                Categoria = "Casacas",
                Precio = 60.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S","M","L","XL" },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C013.png",
                    "~/images/Casacas/C013-1.png",
                    "~/images/Casacas/C013-2.png",
                    "~/images/Casacas/C013-3.png",
                    "~/images/Casacas/C013-4.png"
                }
            },
            new Producto
            {
                Id = "C014",
                Nombre = "SHEIN LUNE Abrigo trench casual para mujeres, otoño e invierno",
                Categoria = "Casacas",
                Precio = 50.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Azul" },
                Talla = new List<string> { "S","M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C014.png",
                    "~/images/Casacas/C014-1.png",
                    "~/images/Casacas/C014-2.png",
                    "~/images/Casacas/C014-3.png",
                    "~/images/Casacas/C014-4.png"
                }
            },
            new Producto
            {
                Id = "C015",
                Nombre = "SHEIN Chaqueta con textura de estampado de leopardo, para uso casual y de oficina",
                Categoria = "Casacas",
                Precio = 35.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S","M","XL" },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C015.png",
                    "~/images/Casacas/C015-1.png",
                    "~/images/Casacas/C015-2.png",
                    "~/images/Casacas/C015-3.png",
                    "~/images/Casacas/C015-4.png"
                }
            },
            new Producto
            {
                Id = "C016",
                Nombre = "SHEIN EZwear Sudadera con capucha de punto con cremallera de color albaricoque",
                Categoria = "Casacas",
                Precio = 35.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Albaricoque" },
                Talla = new List<string> { "M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C016.png",
                    "~/images/Casacas/C016-1.png",
                    "~/images/Casacas/C016-2.png",
                    "~/images/Casacas/C016-3.png",
                    "~/images/Casacas/C016-4.png"
                }
            },
            new Producto
            {
                Id = "C017",
                Nombre = "SHEIN MUSMIN Chaqueta corta de unicolor de manga larga",
                Categoria = "Casacas",
                Precio = 60.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Marrón" },
                Talla = new List<string> { "S","M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Casacas/C017.png",
                    "~/images/Casacas/C017-1.png",
                    "~/images/Casacas/C017-2.png",
                    "~/images/Casacas/C017-3.png",
                    "~/images/Casacas/C017-4.png"
                }
            },

            
            // POLERAS...

            new Producto
            {
                Id = "PO01",
                Nombre = "SHEIN LUNE Suéter holgado de cuello redondo, manga raglán y a rayas",
                Categoria = "Poleras",
                Precio = 45.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Blanco/Azul" },
                Talla = new List<string> { "S","M","L","XL" },
                Imagenes = new List<string>
                {
                    "~/images/Poleras/PO01.png",
                    "~/images/Poleras/PO01-1.png",
                    "~/images/Poleras/PO01-2.png",
                    "~/images/Poleras/PO01-3.png",
                    "~/images/Poleras/PO01-4.png"
                }
            },

            new Producto
            {
                Id = "PO02",
                Nombre = "SHEIN EZwear Sudadera para mujer de hombros abiertos, informal, de estilo minimalista",
                Categoria = "Poleras",
                Precio = 35.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Poleras/PO02.png",
                    "~/images/Poleras/PO02-1.png",
                    "~/images/Poleras/PO02-2.png",
                    "~/images/Poleras/PO02-3.png",
                    "~/images/Poleras/PO02-4.png"
                }
            },

            new Producto
            {
                Id = "PO03",
                Nombre = "SHEIN Sudadera con capucha oversize casual con mangas largas de hombro caído y cordón",
                Categoria = "Poleras",
                Precio = 55.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "XS" },
                Imagenes = new List<string>
                {
                    "~/images/Poleras/PO03.png",
                    "~/images/Poleras/PO03-1.png",
                    "~/images/Poleras/PO03-2.png",
                    "~/images/Poleras/PO03-3.png",
                    "~/images/Poleras/PO03-4.png"
                }
            },

            new Producto
            {
                Id = "PO04",
                Nombre = "SHEIN Sport Streetz Sudadera con capucha informal con cordón para mujer, efecto teñido anudado",
                Categoria = "Poleras",
                Precio = 29.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Rosado" },
                Talla = new List<string> { "S","L" },
                Imagenes = new List<string>
                {
                    "~/images/Poleras/PO04.png",
                    "~/images/Poleras/PO04-1.png",
                    "~/images/Poleras/PO04-2.png",
                    "~/images/Poleras/PO04-3.png",
                    "~/images/Poleras/PO04-4.png"
                }
            },

            new Producto
            {
                Id = "PO05",
                Nombre = "SHEIN Slayr Sudadera informal de mujer con cuello asimétrico y estampado de ojo",
                Categoria = "Poleras",
                Precio = 27.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Blanco" },
                Talla = new List<string> { "S","M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Poleras/PO05.png",
                    "~/images/Poleras/PO05-1.png",
                    "~/images/Poleras/PO05-2.png",
                    "~/images/Poleras/PO05-3.png",
                    "~/images/Poleras/PO05-4.png"
                }
            },

            new Producto
            {
                Id = "PO06",
                Nombre = "SHEIN Relaxiva Suéter casual holgado de cuello redondo de manga larga con rayas y contraste",
                Categoria = "Poleras",
                Precio = 44.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Beige" },
                Talla = new List<string> { "S","M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Poleras/PO06.png",
                    "~/images/Poleras/PO06-1.png",
                    "~/images/Poleras/PO06-2.png",
                    "~/images/Poleras/PO06-3.png",
                    "~/images/Poleras/PO06-4.png"
                }
            },

            new Producto
            {
                Id = "PO07",
                Nombre = "SHEIN Sudadera con cuello en V, mangas de murciélago gris",
                Categoria = "Poleras",
                Precio = 33.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Gris" },
                Talla = new List<string> { "S","L" },
                Imagenes = new List<string>
                {
                    "~/images/Poleras/PO07.png",
                    "~/images/Poleras/PO07-1.png",
                    "~/images/Poleras/PO07-2.png",
                    "~/images/Poleras/PO07-3.png",
                    "~/images/Poleras/PO07-4.png"
                }
            },

            new Producto
            {
                Id = "PO08",
                Nombre = "SHEIN LUNE Sudadera casual con capucha y bolsillo tipo canguro, sudadera de manga larga",
                Categoria = "Poleras",
                Precio = 40.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Gris" },
                Talla = new List<string> { "M","XL" },
                Imagenes = new List<string>
                {
                    "~/images/Poleras/PO08.png",
                    "~/images/Poleras/PO08-1.png",
                    "~/images/Poleras/PO08-2.png",
                    "~/images/Poleras/PO08-3.png",
                    "~/images/Poleras/PO08-4.png"
                }
            },

            new Producto
            {
                Id = "PO09",
                Nombre = "SHEIN EZwear Jersey con capucha de mujer de color azul profundo con bajo asimétrico y calado",
                Categoria = "Poleras",
                Precio = 34.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Azul Marino" },
                Talla = new List<string> { "S","M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Poleras/PO09.png",
                    "~/images/Poleras/PO09-1.png",
                    "~/images/Poleras/PO09-2.png",
                    "~/images/Poleras/PO09-3.png",
                    "~/images/Poleras/PO09-4.png"
                }
            },

            new Producto
            {
                Id = "PO10",
                Nombre = "SHEIN EZwear Camiseta de manga larga con cuello alto de forro polar doble faz",
                Categoria = "Poleras",
                Precio = 33.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Gris" },
                Talla = new List<string> { "M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Poleras/PO10.png",
                    "~/images/Poleras/PO10-1.png",
                    "~/images/Poleras/PO10-2.png",
                    "~/images/Poleras/PO10-3.png",
                    "~/images/Poleras/PO10-4.png"
                }
            },

            // CARDIGANS...

            new Producto
            {
                Id = "CA01",
                Nombre = "SHEIN LUNE Cárdigan sencillo de unicolor con mangas de murciélago, uso casual de todos los días",
                Categoria = "Cardigans",
                Precio = 35.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Beige" },
                Talla = new List<string> { "M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Cardigans/CA01.png",
                    "~/images/Cardigans/CA01-1.png",
                    "~/images/Cardigans/CA01-2.png",
                    "~/images/Cardigans/CA01-3.png",
                    "~/images/Cardigans/CA01-4.png"
                }
            },

            new Producto
            {
                Id = "CA02",
                Nombre = "SHEIN Chaqueta larga, holgada y casual de terciopelo con estampado de leopardo metálico elegante",
                Categoria = "Cardigans",
                Precio = 35.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Leopardo" },
                Talla = new List<string> { "S","M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Cardigans/CA02.png",
                    "~/images/Cardigans/CA02-1.png",
                    "~/images/Cardigans/CA02-2.png",
                    "~/images/Cardigans/CA02-3.png",
                    "~/images/Cardigans/CA02-4.png"
                }
            },

            // BLAZER...

            new Producto
            {
                Id = "BL01",
                Nombre = "SHEIN Privé Blazer ribete lanudo crop tweed",
                Categoria = "Blazer",
                Precio = 65.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Blanco" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Blazer/BL01.png",
                    "~/images/Blazer/BL01-1.png",
                    "~/images/Blazer/BL01-2.png",
                    "~/images/Blazer/BL01-3.png",
                    "~/images/Blazer/BL01-4.png"
                }
            },

            new Producto
            {
                Id = "BL02",
                Nombre = "SHEIN Essnce Chaqueta corta casual con estampado y frente abierto",
                Categoria = "Blazer",
                Precio = 37.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Multicolor" },
                Talla = new List<string> { "M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Blazer/BL02.png",
                    "~/images/Blazer/BL02-1.png",
                    "~/images/Blazer/BL02-2.png",
                    "~/images/Blazer/BL02-3.png",
                    "~/images/Blazer/BL02-4.png"
                }
            },

            new Producto
            {
                Id = "BL03",
                Nombre = "SHEIN Raffinéa Chaqueta de blazer de doble botonadura sobrecampana de color contrastante",
                Categoria = "Blazer",
                Precio = 50.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Beige" },
                Talla = new List<string> { "XL" },
                Imagenes = new List<string>
                {
                    "~/images/Blazer/BL03.png",
                    "~/images/Blazer/BL03-1.png",
                    "~/images/Blazer/BL03-2.png",
                    "~/images/Blazer/BL03-3.png",
                    "~/images/Blazer/BL03-4.png"
                }
            },

            new Producto
            {
                Id = "BL04",
                Nombre = "SHEIN Raffinéa Chaqueta blazer de ajuste regular de un solo pecho con bolsillos con solapa",
                Categoria = "Blazer",
                Precio = 45.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Beige" },
                Talla = new List<string> { "M","L","XL" },
                Imagenes = new List<string>
                {
                    "~/images/Blazer/BL04.png",
                    "~/images/Blazer/BL04-1.png",
                    "~/images/Blazer/BL04-2.png",
                    "~/images/Blazer/BL04-3.png",
                    "~/images/Blazer/BL04-4.png"
                }
            },

            new Producto
            {
                Id = "BL05",
                Nombre = "SHEIN LUNE Chaqueta de trabajo, de estilo minimalista y casual, con cuello vuelto\r\n",
                Categoria = "Blazer",
                Precio = 35.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Celeste" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Blazer/BL05.png",
                    "~/images/Blazer/BL05-1.png",
                    "~/images/Blazer/BL05-2.png",
                    "~/images/Blazer/BL05-3.png",
                    "~/images/Blazer/BL05-4.png"
                }
            },

            new Producto
            {
                Id = "BL06",
                Nombre = "SHEIN AiiRZ Chaqueta blazer con mangas abullonadas y plisadas oversize",
                Categoria = "Blazer",
                Precio = 53.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "XS" },
                Imagenes = new List<string>
                {
                    "~/images/Blazer/BL06.png",
                    "~/images/Blazer/BL06-1.png",
                    "~/images/Blazer/BL06-2.png",
                    "~/images/Blazer/BL06-3.png",
                    "~/images/Blazer/BL06-4.png"
                }
            },

            // ABRIGOS...

            new Producto
            {
                Id = "A001",
                Nombre = "SHEIN LUNE Abrigo regular grueso y cálido de cuello redondo gris para mujer, invierno",
                Categoria = "Abrigos",
                Precio = 64.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Gris" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Abrigos/A001.png",
                    "~/images/Abrigos/A001-1.png",
                    "~/images/Abrigos/A001-2.png",
                    "~/images/Abrigos/A001-3.png",
                    "~/images/Abrigos/A001-4.png"
                }
            },

            new Producto
            {
                Id = "A002",
                Nombre = "SHEIN SXY Abrigo de poncho de mujer marrón y mullido, abrigo de peluche",
                Categoria = "Abrigos",
                Precio = 77.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Marrón" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Abrigos/A002.png",
                    "~/images/Abrigos/A002-1.png",
                    "~/images/Abrigos/A002-2.png",
                    "~/images/Abrigos/A002-3.png",
                    "~/images/Abrigos/A002-4.png"
                }
            },

            new Producto
            {
                Id = "A003",
                Nombre = "SHEIN LUNE Chaqueta casual de forro polar a cuadros, otoño e invierno",
                Categoria = "Abrigos",
                Precio = 59.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Melón" },
                Talla = new List<string> { "S","M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Abrigos/A003.png",
                    "~/images/Abrigos/A003-1.png",
                    "~/images/Abrigos/A003-2.png",
                    "~/images/Abrigos/A003-3.png",
                    "~/images/Abrigos/A003-4.png"
                }
            },


            // VESTIDOS...

            new Producto
            {
                Id = "V001",
                Nombre = "SHEIN AiiRZ Elegante minivestido con cuello alto, mangas de globo y detalle en la cintura alta",
                Categoria = "Vestidos",
                Precio = 50.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Blanco" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Vestidos/V001.png",
                    "~/images/Vestidos/V001-1.png",
                    "~/images/Vestidos/V001-2.png",
                    "~/images/Vestidos/V001-3.png",
                    "~/images/Vestidos/V001-4.png"
                }
            },
            new Producto
            {
                Id = "V002",
                Nombre = "SHEIN Lady Vestido Con Botones Y Cuello Vuelto, Plus Size, De Encaje Con Bolsillos De Solapa",
                Categoria = "Vestidos",
                Precio = 75.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Blanco" },
                Talla = new List<string> { "XL" },
                Imagenes = new List<string>
                {
                    "~/images/Vestidos/V002.png",
                    "~/images/Vestidos/V002-1.png",
                    "~/images/Vestidos/V002-2.png",
                    "~/images/Vestidos/V002-3.png",
                    "~/images/Vestidos/V002-4.png"
                }
            },
            new Producto
            {
                Id = "V003",
                Nombre = "SHEIN Vestido camisa casual de mujer de manga corta con botones y estampado de veta de madera con cinturón anudado",
                Categoria = "Vestidos",
                Precio = 56.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Verde" },
                Talla = new List<string> { "XL" },
                Imagenes = new List<string>
                {
                    "~/images/Vestidos/V003.png",
                    "~/images/Vestidos/V003-1.png",
                    "~/images/Vestidos/V003-2.png",
                    "~/images/Vestidos/V003-3.png",
                    "~/images/Vestidos/V003-4.png"
                }
            },
            new Producto
            {
                Id = "V004",
                Nombre = "SHEIN Privé Vestido ajustado con transparencias y abertura",
                Categoria = "Vestidos",
                Precio = 37.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Vestidos/V004.png",
                    "~/images/Vestidos/V004-1.png",
                    "~/images/Vestidos/V004-2.png",
                    "~/images/Vestidos/V004-3.png",
                    "~/images/Vestidos/V004-4.png"
                }
            },
            new Producto
            {
                Id = "V005",
                Nombre = "SHEIN Vestido casual recto de manga farol con cuello redondo, estampado geométrico suelto",
                Categoria = "Vestidos",
                Precio = 38.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Multicolor" },
                Talla = new List<string> { "XL" },
                Imagenes = new List<string>
                {
                    "~/images/Vestidos/V005.png",
                    "~/images/Vestidos/V005-1.png",
                    "~/images/Vestidos/V005-2.png",
                    "~/images/Vestidos/V005-3.png",
                    "~/images/Vestidos/V005-4.png"
                }
            },
            new Producto
            {
                Id = "V006",
                Nombre = "SHEIN Clasi Vestido casual de mujer con manga enrollable, cinturón",
                Categoria = "Vestidos",
                Precio = 47.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Rojo" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Vestidos/V006.png",
                    "~/images/Vestidos/V006-1.png",
                    "~/images/Vestidos/V006-2.png",
                    "~/images/Vestidos/V006-3.png",
                    "~/images/Vestidos/V006-4.png"
                }
            },
            new Producto
            {
                Id = "V007",
                Nombre = "SHEIN SXY Vestido de mujer con cuello asimétrico, de silueta delgada, cuello asimétrico, malla con abertura, fruncido y abertura",
                Categoria = "Vestidos",
                Precio = 35.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Beige" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Vestidos/V007.png",
                    "~/images/Vestidos/V007-1.png",
                    "~/images/Vestidos/V007-2.png",
                    "~/images/Vestidos/V007-3.png",
                    "~/images/Vestidos/V007-4.png"
                }
            },
            new Producto
            {
                Id = "V008",
                Nombre = "SHEIN SXY Vestido ajustado de tirantes unicolor",
                Categoria = "Vestidos",
                Precio = 15.00m,
                PrecioAnterior = 38.00m,
                Descuento = 25,
                Color = new List<string> { "Rosado" },
                Talla = new List<string> { "XS" },
                Imagenes = new List<string>
                {
                    "~/images/Vestidos/V008.png",
                    "~/images/Vestidos/V008-1.png",
                    "~/images/Vestidos/V008-2.png",
                    "~/images/Vestidos/V008-3.png",
                    "~/images/Vestidos/V008-4.png"
                }
            },
            new Producto
            {
                Id = "V009",
                Nombre = "SHEIN LUNE Vestido casual y holgado con cuello redondo con estampado de plantas",
                Categoria = "Vestidos",
                Precio = 12.00m,
                PrecioAnterior = 28.00m,
                Descuento = 20,
                Color = new List<string> { "Fucsia" },
                Talla = new List<string> { "S","M"  },
                Imagenes = new List<string>
                {
                    "~/images/Vestidos/V009.png",
                    "~/images/Vestidos/V009-1.png",
                    "~/images/Vestidos/V009-2.png",
                    "~/images/Vestidos/V009-3.png",
                    "~/images/Vestidos/V009-4.png"
                }
            },
            new Producto
            {
                Id = "V010",
                Nombre = "SHEIN EZwear Vestido body-con color albaricoque con hombros descubiertos",
                Categoria = "Vestidos",
                Precio = 35.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Beige" },
                Talla = new List<string> { "M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Vestidos/V010.png",
                    "~/images/Vestidos/V010-1.png",
                    "~/images/Vestidos/V010-2.png",
                    "~/images/Vestidos/V010-3.png",
                    "~/images/Vestidos/V010-4.png"
                }
            },
            new Producto
            {
                Id = "V011",
                Nombre = "SHEIN Clasi Vestido Sin Mangas De Mujer Con Impresión De Mariposa Y Bloques De Color",
                Categoria = "Vestidos",
                Precio = 38.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Blanco y Negro" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Vestidos/V011.png",
                    "~/images/Vestidos/V011-1.png",
                    "~/images/Vestidos/V011-2.png",
                    "~/images/Vestidos/V011-3.png",
                    "~/images/Vestidos/V011-4.png"
                }
            },
            new Producto
            {
                Id = "V012",
                Nombre = "SHEIN Belle Vestido envolvente con cuello de surplice y mangas farol en color rojo borgoña",
                Categoria = "Vestidos",
                Precio = 60.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Rojo" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Vestidos/V012.png",
                    "~/images/Vestidos/V012-1.png",
                    "~/images/Vestidos/V012-2.png",
                    "~/images/Vestidos/V012-3.png",
                    "~/images/Vestidos/V012-4.png"
                }
            },
            new Producto
            {
                Id = "V013",
                Nombre = "SHEIN BAE Vestido sexy de manga larga, cuello rectangular, forro de otoño, falda de cola de sirena, ajustado al cuerpo",
                Categoria = "Vestidos",
                Precio = 49.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Gris" },
                Talla = new List<string> { "M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Vestidos/V013.png",
                    "~/images/Vestidos/V013-1.png",
                    "~/images/Vestidos/V013-2.png",
                    "~/images/Vestidos/V013-3.png",
                    "~/images/Vestidos/V013-4.png"
                }
            },
            new Producto
            {
                Id = "V014",
                Nombre = "Vestido Negro de mujer con tirantes finos y abertura",
                Categoria = "Vestidos",
                Precio = 35.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Vestidos/V014.png",
                    "~/images/Vestidos/V014-1.png",
                    "~/images/Vestidos/V014-2.png",
                    "~/images/Vestidos/V014-3.png",
                    "~/images/Vestidos/V014-4.png"
                }
            },
            

            // Conjuntos y Enterizos...

            new Producto
            {
                Id = "E001",
                Nombre = "SHEIN VCAY Mono de mujer de unicolor con cuello en V, cruzado, sin espalda, sin mangas",
                Categoria = "Conjuntos",
                Precio = 37.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Conjuntos-Enterizos/E001.png",
                    "~/images/Conjuntos-Enterizos/E001-1.png",
                    "~/images/Conjuntos-Enterizos/E001-2.png",
                    "~/images/Conjuntos-Enterizos/E001-3.png",
                    "~/images/Conjuntos-Enterizos/E001-4.png"
                }
            },

            new Producto
            {
                Id = "E002",
                Nombre = "SHEIN Conjunto de top de tirantes y mallas para deportes, verano y yoga con medias altas hasta el muslo básicas",
                Categoria = "Conjuntos",
                Precio = 45.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Conjuntos-Enterizos/E002.png",
                    "~/images/Conjuntos-Enterizos/E002-1.png",
                    "~/images/Conjuntos-Enterizos/E002-2.png",
                    "~/images/Conjuntos-Enterizos/E002-3.png",
                    "~/images/Conjuntos-Enterizos/E002-4.png"
                }
            },
            new Producto
            {
                Id = "E003",
                Nombre = "SHEIN Sport Easify Mono deportivo de mujer de unicolor con tirantes cruzados",
                Categoria = "Conjuntos",
                Precio = 50.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S","L" },
                Imagenes = new List<string>
                {
                    "~/images/Conjuntos-Enterizos/E003.png",
                    "~/images/Conjuntos-Enterizos/E003-1.png",
                    "~/images/Conjuntos-Enterizos/E003-2.png",
                    "~/images/Conjuntos-Enterizos/E003-3.png",
                    "~/images/Conjuntos-Enterizos/E003-4.png"
                }
            },
            new Producto
            {
                Id = "E004",
                Nombre = "SHEIN EZwear Conjunto de dos piezas para mujer en unicolor sexy, ajustado al Body, sin tirantes, con top corto y mini falda",
                Categoria = "Conjuntos",
                Precio = 19.00m,
                PrecioAnterior = 39.00m,
                Descuento = 20,
                Color = new List<string> { "Celeste" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Conjuntos-Enterizos/E004.png",
                    "~/images/Conjuntos-Enterizos/E004-1.png",
                    "~/images/Conjuntos-Enterizos/E004-2.png",
                    "~/images/Conjuntos-Enterizos/E004-3.png",
                    "~/images/Conjuntos-Enterizos/E004-4.png"
                }
            },
            new Producto
            {
                Id = "E005",
                Nombre = "SHEIN Conjunto casual con camiseta de cuello redondo de manga corta y short con lazo en la cintura",
                Categoria = "Conjuntos",
                Precio = 37.00m,
                //PrecioAnterior = 39.00m,
                //Descuento = 20,
                Color = new List<string> { "Ladrillo" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Conjuntos-Enterizos/E005.png",
                    "~/images/Conjuntos-Enterizos/E005-1.png",
                    "~/images/Conjuntos-Enterizos/E005-2.png",
                    "~/images/Conjuntos-Enterizos/E005-3.png",
                    "~/images/Conjuntos-Enterizos/E005-4.png"
                }
            },

            // Ropa de dormir...

            new Producto
            {
                Id = "PI001",
                Nombre = "SHEIN Elegante camisón con tirantes finos y abertura lateral",
                Categoria = "Pijamas",
                Precio = 27.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Vino" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Pijamas/PI001.png",
                    "~/images/Pijamas/PI001-1.png",
                    "~/images/Pijamas/PI001-2.png",
                    "~/images/Pijamas/PI001-3.png",
                    "~/images/Pijamas/PI001-4.png"
                }
            },
            new Producto
            {
                Id = "PI002",
                Nombre = "SHEIN Conjunto de bata y pijama de dama con mangas acampanadas y encaje",
                Categoria = "Pijamas",
                Precio = 50.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Pijamas/PI002.png",
                    "~/images/Pijamas/PI002-1.png",
                    "~/images/Pijamas/PI002-2.png",
                    "~/images/Pijamas/PI002-3.png",
                    "~/images/Pijamas/PI002-4.png"
                }
            },
            new Producto
            {
                Id = "PI003",
                Nombre = "SHEIN Camisón de terciopelo con estampado de mariposas",
                Categoria = "Pijamas",
                Precio = 25.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Pijamas/PI003.png",
                    "~/images/Pijamas/PI003-1.png",
                    "~/images/Pijamas/PI003-2.png",
                    "~/images/Pijamas/PI003-3.png",
                    "~/images/Pijamas/PI003-4.png"
                }
            },
            new Producto
            {
                Id = "PI004",
                Nombre = "SHEIN Bata con cuello vuelto acolchada con patrón bordado para mujeres para otoño e invierno",
                Categoria = "Pijamas",
                Precio = 50.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S","M" },
                Imagenes = new List<string>
                {
                    "~/images/Pijamas/PI004.png",
                    "~/images/Pijamas/PI004-1.png",
                    "~/images/Pijamas/PI004-2.png",
                    "~/images/Pijamas/PI004-3.png",
                    "~/images/Pijamas/PI004-4.png"
                }
            },


            // BOLSOS Y MOCHILAS...

            new Producto
            {
                Id = "Z001",
                Nombre = "Bolso De Cintura A Cuadros, Con Doble Cremallera Y Estilo Cruzado NEGRO",
                Categoria = "Bolsos",
                Precio = 20.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Imagenes = new List<string>
                {
                    "~/images/Bolsos/Z001.png",
                    "~/images/Bolsos/Z001-1.png",
                    "~/images/Bolsos/Z001-2.png",
                    "~/images/Bolsos/Z001-3.png",
                    "~/images/Bolsos/Z001-4.png"
                }
            },

            new Producto
            {
                Id = "Z002",
                Nombre = "Elegante bolsa de hombro cruzada de alta calidad, cuenta con un interior de doble capa y una gran capacidad.",
                Categoria = "Bolsos",
                Precio = 47.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Imagenes = new List<string>
                {
                    "~/images/Bolsos/Z002.png",
                    "~/images/Bolsos/Z002-1.png",
                    "~/images/Bolsos/Z002-2.png",
                    "~/images/Bolsos/Z002-3.png",
                    "~/images/Bolsos/Z002-4.png"
                }
            },

            new Producto
            {
                Id = "Z003",
                Nombre = "Elegante bolso cruzado pequeño cuadrado. Al hombro retro con correa ancha y detalle audaz de cadena",
                Categoria = "Bolsos",
                Precio = 29.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Imagenes = new List<string>
                {
                    "~/images/Bolsos/Z003.png",
                    "~/images/Bolsos/Z003-1.png",
                    "~/images/Bolsos/Z003-2.png",
                    "~/images/Bolsos/Z003-3.png",
                    "~/images/Bolsos/Z003-4.png"
                }
            },

            new Producto
            {
                Id = "Z004",
                Nombre = "Bolso Tipo Cubo de Gran Capacidad al Estilo Chino con Detalle de Cordón Ajustable",
                Categoria = "Bolsos",
                Precio = 25.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Blanco" },
                Imagenes = new List<string>
                {
                    "~/images/Bolsos/Z004.png",
                    "~/images/Bolsos/Z004-1.png",
                    "~/images/Bolsos/Z004-2.png",
                    "~/images/Bolsos/Z004-3.png",
                    "~/images/Bolsos/Z004-4.png"
                }
            },

            new Producto
            {
                Id = "Z005",
                Nombre = "Bolsa de hombro versátil con diseño acolchado, bolsa de moda para llevar bajo el brazo",
                Categoria = "Bolsos",
                Precio = 19.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Marrón" },
                Imagenes = new List<string>
                {
                    "~/images/Bolsos/Z005.png",
                    "~/images/Bolsos/Z005-1.png",
                    "~/images/Bolsos/Z005-2.png",
                    "~/images/Bolsos/Z005-3.png",
                    "~/images/Bolsos/Z005-4.png"
                }
            },

            new Producto
            {
                Id = "Z006",
                Nombre = "Bolso de hombro con solapa, minimalista, clásico, pequeño y extravagante, bolso casual y elegante",
                Categoria = "Bolsos",
                Precio = 73.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Beige" },
                Imagenes = new List<string>
                {
                    "~/images/Bolsos/Z006.png",
                    "~/images/Bolsos/Z006-1.png",
                    "~/images/Bolsos/Z006-2.png",
                    "~/images/Bolsos/Z006-3.png",
                    "~/images/Bolsos/Z006-4.png"
                }
            },

            new Producto
            {
                Id = "Z007",
                Nombre = "Mochila de moda, bolsa de viaje casual grande y multifuncional de gran capacidad, bolsillo portátil",
                Categoria = "Bolsos",
                Precio = 60.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Beige" },
                Imagenes = new List<string>
                {
                    "~/images/Bolsos/Z007.png",
                    "~/images/Bolsos/Z007-1.png",
                    "~/images/Bolsos/Z007-2.png",
                    "~/images/Bolsos/Z007-3.png",
                    "~/images/Bolsos/Z007-4.png"
                }
            },

            new Producto
            {
                Id = "Z008",
                Nombre = "Bolso baguette ligero, informal de negocios con hebilla y decoración de cadena",
                Categoria = "Bolsos",
                Precio = 37.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Imagenes = new List<string>
                {
                    "~/images/Bolsos/Z008.png",
                    "~/images/Bolsos/Z008-1.png",
                    "~/images/Bolsos/Z008-2.png",
                    "~/images/Bolsos/Z008-3.png",
                    "~/images/Bolsos/Z008-4.png"
                }
            },

            new Producto
            {
                Id = "Z009",
                Nombre = "Bolso de mano, con encaje, flores y diseño tejido, bolso de hombro casual, nuevos llegados para 2025",
                Categoria = "Bolsos",
                Precio = 35.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Beige" },
                Imagenes = new List<string>
                {
                    "~/images/Bolsos/Z009.png",
                    "~/images/Bolsos/Z009-1.png",
                    "~/images/Bolsos/Z009-2.png",
                    "~/images/Bolsos/Z009-3.png",
                    "~/images/Bolsos/Z009-4.png"
                }
            },

            new Producto
            {
                Id = "Z010",
                Nombre = "Mochila De Pu Ligera, múltiples Compartimentos, Interior Forrado, Con Colgante De Acrílico De Color Dorado",
                Categoria = "Bolsos",
                Precio = 40.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Marrón" },
                Imagenes = new List<string>
                {
                    "~/images/Bolsos/Z010.png",
                    "~/images/Bolsos/Z010-1.png",
                    "~/images/Bolsos/Z010-2.png",
                    "~/images/Bolsos/Z010-3.png",
                    "~/images/Bolsos/Z010-4.png"
                }
            },

            new Producto
            {
                Id = "Z011",
                Nombre = "Bolso de hombro tipo cruzado cuadrado con solapa y diseño de moño en costura de piel de poliuretano",
                Categoria = "Bolsos",
                Precio = 37.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Imagenes = new List<string>
                {
                    "~/images/Bolsos/Z011.png",
                    "~/images/Bolsos/Z011-1.png",
                    "~/images/Bolsos/Z011-2.png",
                    "~/images/Bolsos/Z011-3.png",
                    "~/images/Bolsos/Z011-4.png"
                }
            },

            new Producto
            {
                Id = "Z012",
                Nombre = "Bolso de hombro de moda mini con patrón geométrico",
                Categoria = "Bolsos",
                Precio = 25.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Imagenes = new List<string>
                {
                    "~/images/Bolsos/Z012.png",
                    "~/images/Bolsos/Z012-1.png",
                    "~/images/Bolsos/Z012-2.png",
                    "~/images/Bolsos/Z012-3.png",
                    "~/images/Bolsos/Z012-4.png"
                }
            },

           

            new Producto
            {
                Id = "Z014",
                Nombre = "Bolso de mano vintage minimalista con cierre giratorio, bolso cruzado convertible",
                Categoria = "Bolsos",
                Precio = 73.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Beige" },
                Imagenes = new List<string>
                {
                    "~/images/Bolsos/Z014.png",
                    "~/images/Bolsos/Z014-1.png",
                    "~/images/Bolsos/Z014-2.png",
                    "~/images/Bolsos/Z014-3.png",
                    "~/images/Bolsos/Z014-4.png"
                }
            },

            new Producto
            {
                Id = "Z015",
                Nombre = "Bolso de PU acolchado con solapa, bolso con cadena metálica cuadrada de gran capacidad",
                Categoria = "Bolsos",
                Precio = 39.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Negro" },
                Imagenes = new List<string>
                {
                    "~/images/Bolsos/Z015.png",
                    "~/images/Bolsos/Z015-1.png",
                    "~/images/Bolsos/Z015-2.png",
                    "~/images/Bolsos/Z015-3.png",
                    "~/images/Bolsos/Z015-4.png"
                }
            },

            new Producto
            {
                Id = "Z016",
                Nombre = "Bolso de hombro color marrón, bolso cruzado de moda, pequeño bolso cuadrado elegante y ligero",
                Categoria = "Bolsos",
                Precio = 30.00m,
                //PrecioAnterior = 50.00m,
                //Descuento = 10,
                Color = new List<string> { "Marrón" },
                Imagenes = new List<string>
                {
                    "~/images/Bolsos/Z016.png",
                    "~/images/Bolsos/Z016-1.png",
                    "~/images/Bolsos/Z016-2.png",
                    "~/images/Bolsos/Z016-3.png",
                    "~/images/Bolsos/Z016-4.png"
                }
            },


            // Bebés...

            new Producto
            {
                Id = "BB01",
                Nombre = "SHEIN Chaqueta con capucha y cremallera, ropa de otoño/invierno",
                Categoria = "Bebes",
                Precio = 40.00m,
                PrecioAnterior = 50.00m,
                Descuento = 10,
                Color = new List<string> { "Azul" },
                Talla = new List<string> { "6 a 9 meses", "9 a 12 meses", "12 a 18 meses" },
                Imagenes = new List<string>
                {
                    "~/images/Bebes/BB01.png",
                    "~/images/Bebes/BB01-1.png",
                    "~/images/Bebes/BB01-2.png",
                    "~/images/Bebes/BB01-3.png",
                    "~/images/Bebes/BB01-4.png"
                }
            },

            
            // LIQUIDACION...

            new Producto
            {
                Id = "L001",
                Nombre = "SHEIN Swim Conjunto de bikini con estampado de mármol, sujetador halter y la Bottom del bikini",
                Categoria = "Liquidacion",
                Precio = 27.00m,
                PrecioAnterior = 55.00m,
                Descuento = 50,
                Color = new List<string> { "Mármol" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Liquidacion/L001.png",
                    "~/images/Liquidacion/L001-1.png",
                    "~/images/Liquidacion/L001-2.png",
                    "~/images/Liquidacion/L001-3.png",
                    "~/images/Liquidacion/L001-4.png"
                }
            },

            new Producto
            {
                Id = "L002",
                Nombre = "SHEIN Traje de baño tankini de malla de contraste",
                Categoria = "Liquidacion",
                Precio = 27.00m,
                PrecioAnterior = 55.00m,
                Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Liquidacion/L002.png",
                    "~/images/Liquidacion/L002-1.png",
                    "~/images/Liquidacion/L002-2.png",
                    "~/images/Liquidacion/L002-3.png",
                    "~/images/Liquidacion/L002-4.png"
                }
            },

            new Producto
            {
                Id = "L003",
                Nombre = "SHEIN Falda con estampado total y cordones, de línea A para mujer, uso diario casual",
                Categoria = "Liquidacion",
                Precio = 15.00m,
                PrecioAnterior = 30.00m,
                Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "XS" },
                Imagenes = new List<string>
                {
                    "~/images/Liquidacion/L003.png",
                    "~/images/Liquidacion/L003-1.png",
                    "~/images/Liquidacion/L003-2.png",
                    "~/images/Liquidacion/L003-3.png",
                    "~/images/Liquidacion/L003-4.png"
                }
            },

            new Producto
            {
                Id = "L004",
                Nombre = "SHEIN ROMWE Hippie Shorts Vaqueros Bordados Con Diseño De Sol, Luna Y Estrellas Mágicas",
                Categoria = "Liquidacion",
                Precio = 30.00m,
                PrecioAnterior = 60.00m,
                Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "XS" },
                Imagenes = new List<string>
                {
                    "~/images/Liquidacion/L004.png",
                    "~/images/Liquidacion/L004-1.png",
                    "~/images/Liquidacion/L004-2.png",
                    "~/images/Liquidacion/L004-3.png",
                    "~/images/Liquidacion/L004-4.png"
                }
            },

            new Producto
            {
                Id = "L005",
                Nombre = "SHEIN SXY Shorts caqui de cintura alta de verano con bolsillos con solapa lateral",
                Categoria = "Liquidacion",
                Precio = 19.00m,
                PrecioAnterior = 30.00m,
                Descuento = 40,
                Color = new List<string> { "Rosa" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Liquidacion/L005.png",
                    "~/images/Liquidacion/L005-1.png",
                    "~/images/Liquidacion/L005-2.png",
                    "~/images/Liquidacion/L005-3.png",
                    "~/images/Liquidacion/L005-4.png"
                }
            },

            new Producto
            {
                Id = "L006",
                Nombre = "SHEIN SXY Pantalones cortos casuales sueltos de unicolor con lazo en la cintura",
                Categoria = "Liquidacion",
                Precio = 10.00m,
                PrecioAnterior = 20.00m,
                Descuento = 50,
                Color = new List<string> { "Ladrillo" },
                Talla = new List<string> { "XS" },
                Imagenes = new List<string>
                {
                    "~/images/Liquidacion/L006.png",
                    "~/images/Liquidacion/L006-1.png",
                    "~/images/Liquidacion/L006-2.png",
                    "~/images/Liquidacion/L006-3.png",
                    "~/images/Liquidacion/L006-4.png"
                }
            },

            new Producto
            {
                Id = "L007",
                Nombre = "SHEIN EZwear Shorts de mezclilla con dobladillo crudo rasgado y cintura alta de moda",
                Categoria = "Liquidacion",
                Precio = 30.00m,
                PrecioAnterior = 60.00m,
                Descuento = 50,
                Color = new List<string> { "Celeste" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Liquidacion/L007.png",
                    "~/images/Liquidacion/L007-1.png",
                    "~/images/Liquidacion/L007-2.png",
                    "~/images/Liquidacion/L007-3.png",
                    "~/images/Liquidacion/L007-4.png"
                }
            },

            new Producto
            {
                Id = "L008",
                Nombre = "SHEIN EZwear Pantalones cortos de mezclilla desgarrados informales",
                Categoria = "Liquidacion",
                Precio = 30.00m,
                PrecioAnterior = 60.00m,
                Descuento = 50,
                Color = new List<string> { "Negro Nevado" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Liquidacion/L008.png",
                    "~/images/Liquidacion/L008-1.png",
                    "~/images/Liquidacion/L008-2.png",
                    "~/images/Liquidacion/L008-3.png",
                    "~/images/Liquidacion/L008-4.png"
                }
            },

            new Producto
            {
                Id = "L009",
                Nombre = "SHEIN Essnce Shorts de mezclilla rasgados simples y casuales para mujeres, shorts vaqueros",
                Categoria = "Liquidacion",
                Precio = 30.00m,
                PrecioAnterior = 60.00m,
                Descuento = 50,
                Color = new List<string> { "Azul Claro" },
                Talla = new List<string> { "XS","S" },
                Imagenes = new List<string>
                {
                    "~/images/Liquidacion/L009.png",
                    "~/images/Liquidacion/L009-1.png",
                    "~/images/Liquidacion/L009-2.png",
                    "~/images/Liquidacion/L009-3.png",
                    "~/images/Liquidacion/L009-4.png"
                }
            },


            // DEPORTIVO...
            // CAMISETAS...

            new Producto
            {
                Id = "DEC001",
                Nombre = "SHEIN Sport Studio Camiseta deportiva de manga larga con estampado geométrico y bajo curvo",
                Categoria = "Camisetas",
                Precio = 27.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Verde Agua" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/C001.png",
                    "~/images/Deportivo/C001-1.png",
                    "~/images/Deportivo/C001-2.png",
                    "~/images/Deportivo/C001-3.png",
                    "~/images/Deportivo/C001-4.png"
                }
            },

            new Producto
            {
                Id = "DEC002",
                Nombre = "SHEIN Top deportivo de malla de contraste",
                Categoria = "Camisetas",
                Precio = 19.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Blanco" },
                Talla = new List<string> { "XL" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/C002.png",
                    "~/images/Deportivo/C002-1.png",
                    "~/images/Deportivo/C002-2.png",
                    "~/images/Deportivo/C002-3.png",
                    "~/images/Deportivo/C002-4.png"
                }
            },

            new Producto
            {
                Id = "DEC003",
                Nombre = "SHEIN Exploreva Camiseta deportiva transpirable suave unicolor lila",
                Categoria = "Camisetas",
                Precio = 32.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Lila" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/C003.png",
                    "~/images/Deportivo/C003-1.png",
                    "~/images/Deportivo/C003-2.png",
                    "~/images/Deportivo/C003-3.png",
                    "~/images/Deportivo/C003-4.png"
                }
            },

            new Producto
            {
                Id = "DEC004",
                Nombre = "SHEIN Sport Gameset Camiseta deportiva de ombré de manga raglán bajo curvo",
                Categoria = "Camisetas",
                Precio = 26.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Blanco" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/C004.png",
                    "~/images/Deportivo/C004-1.png",
                    "~/images/Deportivo/C004-2.png",
                    "~/images/Deportivo/C004-3.png",
                    "~/images/Deportivo/C004-4.png"
                }
            },

            new Producto
            {
                Id = "DEC005",
                Nombre = "SHEIN Exploreva Camiseta deportiva unicolor bajo curvo",
                Categoria = "Camisetas",
                Precio = 20.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Lila" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/C005.png",
                    "~/images/Deportivo/C005-1.png",
                    "~/images/Deportivo/C005-2.png",
                    "~/images/Deportivo/C005-3.png",
                    "~/images/Deportivo/C005-4.png"
                }
            },

            new Producto
            {
                Id = "DEC006",
                Nombre = "SHEIN Sport Studio Camiseta Deportiva De Manga Raglán Con Inserciones De Malla",
                Categoria = "Camisetas",
                Precio = 20.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Blanco" },
                Talla = new List<string> { "XL" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/C006.png",
                    "~/images/Deportivo/C006-1.png",
                    "~/images/Deportivo/C006-2.png",
                    "~/images/Deportivo/C006-3.png",
                    "~/images/Deportivo/C006-4.png"
                }
            },

            new Producto
            {
                Id = "DEC007",
                Nombre = "SHEIN Sport Studio Top tank deportivo unicolor con abertura trasera",
                Categoria = "Camisetas",
                Precio = 17.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/C007.png",
                    "~/images/Deportivo/C007-1.png",
                    "~/images/Deportivo/C007-2.png",
                    "~/images/Deportivo/C007-3.png",
                    "~/images/Deportivo/C007-4.png"
                }
            },

            new Producto
            {
                Id = "DEC008",
                Nombre = "SHEIN Sport Studio Camiseta deportiva transpirable suave",
                Categoria = "Camisetas",
                Precio = 21.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Blanco" },
                Talla = new List<string> { "S","M" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/C008.png",
                    "~/images/Deportivo/C008-1.png",
                    "~/images/Deportivo/C008-2.png",
                    "~/images/Deportivo/C008-3.png",
                    "~/images/Deportivo/C008-4.png"
                }
            },

            new Producto
            {
                Id = "DEC009",
                Nombre = "SHEIN Sport Gameset Camiseta deportiva unicolor de manga raglán",
                Categoria = "Camisetas",
                Precio = 20.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Blanco" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/C009.png",
                    "~/images/Deportivo/C009-1.png",
                    "~/images/Deportivo/C009-2.png",
                    "~/images/Deportivo/C009-3.png",
                    "~/images/Deportivo/C009-4.png"
                }
            },

            new Producto
            {
                Id = "DEC010",
                Nombre = "SHEIN Camiseta deportiva sin mangas para el verano con cuello redondo, unicolor y espalda abierta",
                Categoria = "Camisetas",
                Precio = 18.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Verde Agua" },
                Talla = new List<string> { "S","M" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/C010.png",
                    "~/images/Deportivo/C010-1.png",
                    "~/images/Deportivo/C010-2.png",
                    "~/images/Deportivo/C010-3.png",
                    "~/images/Deportivo/C010-4.png"
                }
            },

            new Producto
            {
                Id = "DEC011",
                Nombre = "SHEIN Sport Studio Camiseta Deportiva",
                Categoria = "Camisetas",
                Precio = 22.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Azul Marino" },
                Talla = new List<string> { "S","M" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/C011.png",
                    "~/images/Deportivo/C011-1.png",
                    "~/images/Deportivo/C011-2.png",
                    "~/images/Deportivo/C011-3.png",
                    "~/images/Deportivo/C011-4.png"
                }
            },

            // SHORTS DEPORTIVOS...

            new Producto
            {
                Id = "DES001",
                Nombre = "SHEIN Cheerettes Shorts biker de cintura ancha con bolsillo de móvil lateral",
                Categoria = "Shorts Deportivos",
                Precio = 25.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Plomo" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/S001.png",
                    "~/images/Deportivo/S001-1.png",
                    "~/images/Deportivo/S001-2.png",
                    "~/images/Deportivo/S001-3.png",
                    "~/images/Deportivo/S001-4.png"
                }
            },

            new Producto
            {
                Id = "DES002",
                Nombre = "SHEIN Short deportivo con estampado floral y bolsillos, tipo pantalón corto de ciclista",
                Categoria = "Shorts Deportivos",
                Precio = 25.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Floreado" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/S002.png",
                    "~/images/Deportivo/S002-1.png",
                    "~/images/Deportivo/S002-2.png",
                    "~/images/Deportivo/S002-3.png",
                    "~/images/Deportivo/S002-4.png"
                }
            },

            new Producto
            {
                Id = "DES003",
                Nombre = "SHEIN Pantalones cortos deportivos de cintura alta con estampado floral, cinturón y bolsillos",
                Categoria = "Shorts Deportivos",
                Precio = 25.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Floreado" },
                Talla = new List<string> { "XL" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/S003.png",
                    "~/images/Deportivo/S003-1.png",
                    "~/images/Deportivo/S003-2.png",
                    "~/images/Deportivo/S003-3.png",
                    "~/images/Deportivo/S003-4.png"
                }
            },

            new Producto
            {
                Id = "DES004",
                Nombre = "SHEIN Sport Studio Shorts biker de cintura ancha con bolsillo de móvil lateral",
                Categoria = "Shorts Deportivos",
                Precio = 24.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Vino" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/S004.png",
                    "~/images/Deportivo/S004-1.png",
                    "~/images/Deportivo/S004-2.png",
                    "~/images/Deportivo/S004-3.png",
                    "~/images/Deportivo/S004-4.png"
                }
            },

            new Producto
            {
                Id = "DES005",
                Nombre = "SHEIN Sport Studio Shorts Deportivos De Cintura Elástica",
                Categoria = "Shorts Deportivos",
                Precio = 25.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Gris" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/S005.png",
                    "~/images/Deportivo/S005-1.png",
                    "~/images/Deportivo/S005-2.png",
                    "~/images/Deportivo/S005-3.png",
                    "~/images/Deportivo/S005-4.png"
                }
            },

            new Producto
            {
                Id = "DES006",
                Nombre = "SHEIN Short deportivo con cintura ancha y diseño de letras con bolsillo para teléfono",
                Categoria = "Shorts Deportivos",
                Precio = 23.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Azul Marino" },
                Talla = new List<string> { "M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/S006.png",
                    "~/images/Deportivo/S006-1.png",
                    "~/images/Deportivo/S006-2.png",
                    "~/images/Deportivo/S006-3.png",
                    "~/images/Deportivo/S006-4.png"
                }
            },

            new Producto
            {
                Id = "DES007",
                Nombre = "SHEIN Sport Gameset Shorts deportivos para mujer con paneles de malla",
                Categoria = "Shorts Deportivos",
                Precio = 27.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/S007.png",
                    "~/images/Deportivo/S007-1.png",
                    "~/images/Deportivo/S007-2.png",
                    "~/images/Deportivo/S007-3.png",
                    "~/images/Deportivo/S007-4.png"
                }
            },

            new Producto
            {
                Id = "DES008",
                Nombre = "SHEIN Short deportivo elástico con cintura ancha y dobladillo estilo delfín bolsillo interno",
                Categoria = "Shorts Deportivos",
                Precio = 25.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S","M" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/S008.png",
                    "~/images/Deportivo/S008-1.png",
                    "~/images/Deportivo/S008-2.png",
                    "~/images/Deportivo/S008-3.png",
                    "~/images/Deportivo/S008-4.png"
                }
            },

            new Producto
            {
                Id = "DES009",
                Nombre = "SHEIN Pantalones cortos de entrenamiento deportivo con bolsillo para teléfono y gráficos de letras en el lateral",
                Categoria = "Shorts Deportivos",
                Precio = 23.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Fucsia" },
                Talla = new List<string> { "M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/S009.png",
                    "~/images/Deportivo/S009-1.png",
                    "~/images/Deportivo/S009-2.png",
                    "~/images/Deportivo/S009-3.png",
                    "~/images/Deportivo/S009-4.png"
                }
            },

            new Producto
            {
                Id = "DES010",
                Nombre = "SHEIN Sport Studio Shorts biker de cintura ancha con bolsillo de móvil lateral",
                Categoria = "Shorts Deportivos",
                Precio = 24.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Morado" },
                Talla = new List<string> { "M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/S010.png",
                    "~/images/Deportivo/S010-1.png",
                    "~/images/Deportivo/S010-2.png",
                    "~/images/Deportivo/S010-3.png",
                    "~/images/Deportivo/S010-4.png"
                }
            },

            new Producto
            {
                Id = "DES011",
                Nombre = "SHEIN Sport Studio Shorts deportivos con cintura elástica de unicolor y bolsillo para teléfono (tallas grandes)",
                Categoria = "Shorts Deportivos",
                Precio = 26.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S","M","XL" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/S011.png",
                    "~/images/Deportivo/S011-1.png",
                    "~/images/Deportivo/S011-2.png",
                    "~/images/Deportivo/S011-3.png",
                    "~/images/Deportivo/S011-4.png"
                }
            },

            new Producto
            {
                Id = "DES012",
                Nombre = "SHEIN Sport Studio Shorts ajustados de banda ancha con gráfico de letras para ciclista, shorts elásticos",
                Categoria = "Shorts Deportivos",
                Precio = 17.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/S012.png",
                    "~/images/Deportivo/S012-1.png",
                    "~/images/Deportivo/S012-2.png",
                    "~/images/Deportivo/S012-3.png",
                    "~/images/Deportivo/S012-4.png"
                }
            },

            new Producto
            {
                Id = "DES013",
                Nombre = "SHEIN Pantalones cortos deportivos sin costuras de cintura ancha sólida, pantalones cortos de gimnasia",
                Categoria = "Shorts Deportivos",
                Precio = 19.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Rojo" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/S013.png",
                    "~/images/Deportivo/S013-1.png",
                    "~/images/Deportivo/S013-2.png",
                    "~/images/Deportivo/S013-3.png",
                    "~/images/Deportivo/S013-4.png"
                }
            },

            // LEGGINS...

            
            new Producto
            {
                Id = "DEL001",
                Nombre = "SHEIN Maternidad Leggings bolsillo de celular con puntada de cintura ancha",
                Categoria = "Leggins",
                Precio = 38.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Gris Oscuro" },
                Talla = new List<string> { "XL" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L001.png",
                    "~/images/Deportivo/L001-1.png",
                    "~/images/Deportivo/L001-2.png",
                    "~/images/Deportivo/L001-3.png",
                    "~/images/Deportivo/L001-4.png"
                }
            },

            new Producto
            {
                Id = "DEL002",
                Nombre = "SHEIN Sport Studio Leggings deportivos absorbe el sudor de malla en contraste con bolsillo de celular",
                Categoria = "Leggins",
                Precio = 35.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Lila" },
                Talla = new List<string> { "XL" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L002.png",
                    "~/images/Deportivo/L002-1.png",
                    "~/images/Deportivo/L002-2.png",
                    "~/images/Deportivo/L002-3.png",
                    "~/images/Deportivo/L002-4.png"
                }
            },

            new Producto
            {
                Id = "DEL003",
                Nombre = "SHEIN Sport Studio Leggings deportivos de cintura ancha con bolsillo de móvil lateral",
                Categoria = "Leggins",
                Precio = 30.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Vino" },
                Talla = new List<string> { "XL" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L003.png",
                    "~/images/Deportivo/L003-1.png",
                    "~/images/Deportivo/L003-2.png",
                    "~/images/Deportivo/L003-3.png",
                    "~/images/Deportivo/L003-4.png"
                }
            },

            new Producto
            {
                Id = "DEL004",
                Nombre = "SHEIN Sport Gameset Leggins Deportivo",
                Categoria = "Leggins",
                Precio = 29.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Azul Marino" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L004.png",
                    "~/images/Deportivo/L004-1.png",
                    "~/images/Deportivo/L004-2.png",
                    "~/images/Deportivo/L004-3.png",
                    "~/images/Deportivo/L004-4.png"
                }
            },

            new Producto
            {
                Id = "DEL005",
                Nombre = "SHEIN Sport Studio Mallas de mujer con malla, de cintura alta con control de abdomen",
                Categoria = "Leggins",
                Precio = 28.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L005.png",
                    "~/images/Deportivo/L005-1.png",
                    "~/images/Deportivo/L005-2.png",
                    "~/images/Deportivo/L005-3.png",
                    "~/images/Deportivo/L005-4.png"
                }
            },

            new Producto
            {
                Id = "DEL006",
                Nombre = "SHEIN Sport Studio Leggings Deportivos De Malla De Contraste",
                Categoria = "Leggins",
                Precio = 33.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "XL" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L006.png",
                    "~/images/Deportivo/L006-1.png",
                    "~/images/Deportivo/L006-2.png",
                    "~/images/Deportivo/L006-3.png",
                    "~/images/Deportivo/L006-4.png"
                }
            },

            new Producto
            {
                Id = "DEL007",
                Nombre = "SHEIN Mallas deportivas de cintura ancha con inserción de malla con bolsillo para teléfono",
                Categoria = "Leggins",
                Precio = 29.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "XL" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L007.png",
                    "~/images/Deportivo/L007-1.png",
                    "~/images/Deportivo/L007-2.png",
                    "~/images/Deportivo/L007-3.png",
                    "~/images/Deportivo/L007-4.png"
                }
            },

            new Producto
            {
                Id = "DEL008",
                Nombre = "SHEIN In My Nature Pantalones simples y lisos para mujer con tirantes cruzados",
                Categoria = "Leggins",
                Precio = 39.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L008.png",
                    "~/images/Deportivo/L008-1.png",
                    "~/images/Deportivo/L008-2.png",
                    "~/images/Deportivo/L008-3.png",
                    "~/images/Deportivo/L008-4.png"
                }
            },

            new Producto
            {
                Id = "DEL009",
                Nombre = "SHEIN Sport Studio Leggings deportivos de cintura ancha con bolsillo de celular",
                Categoria = "Leggins",
                Precio = 27.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Gris Oscuro" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L009.png",
                    "~/images/Deportivo/L009-1.png",
                    "~/images/Deportivo/L009-2.png",
                    "~/images/Deportivo/L009-3.png",
                    "~/images/Deportivo/L009-4.png"
                }
            },

            new Producto
            {
                Id = "DEL010",
                Nombre = "Seamluxe SHEIN Sport Leggings Deportivos Con Cintura Ancha",
                Categoria = "Leggins",
                Precio = 30.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L010.png",
                    "~/images/Deportivo/L010-1.png",
                    "~/images/Deportivo/L010-2.png",
                    "~/images/Deportivo/L010-3.png",
                    "~/images/Deportivo/L010-4.png"
                }
            },

            new Producto
            {
                Id = "DEL011",
                Nombre = "SHEIN Musera Sport Mallas ajustadas de cintura alta de activewear deportivo",
                Categoria = "Leggins",
                Precio = 35.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L011.png",
                    "~/images/Deportivo/L011-1.png",
                    "~/images/Deportivo/L011-2.png",
                    "~/images/Deportivo/L011-3.png",
                    "~/images/Deportivo/L011-4.png"
                }
            },

            new Producto
            {
                Id = "DEL012",
                Nombre = "SHEIN Leggings con bloques de color hasta la mitad de la pantorrilla con control de barriga de gran elasticidad con bolsillo lateral y malla en contraste",
                Categoria = "Leggins",
                Precio = 29.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "XS","M" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L012.png",
                    "~/images/Deportivo/L012-1.png",
                    "~/images/Deportivo/L012-2.png",
                    "~/images/Deportivo/L012-3.png",
                    "~/images/Deportivo/L012-4.png"
                }
            },

            new Producto
            {
                Id = "DEL013",
                Nombre = "SHEIN Mallas de yoga Transpirable Suavidad Control de barriga Medias deportivas con pretina ancha",
                Categoria = "Leggins",
                Precio = 30.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S","M","L" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L013.png",
                    "~/images/Deportivo/L013-1.png",
                    "~/images/Deportivo/L013-2.png",
                    "~/images/Deportivo/L013-3.png",
                    "~/images/Deportivo/L013-4.png"
                }
            },

            new Producto
            {
                Id = "DEL014",
                Nombre = "SHEIN Mallas de compresión con inserto de malla de control de barriga sin costuras con bolsillo lateral para teléfono",
                Categoria = "Leggins",
                Precio = 37.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L014.png",
                    "~/images/Deportivo/L014-1.png",
                    "~/images/Deportivo/L014-2.png",
                    "~/images/Deportivo/L014-3.png",
                    "~/images/Deportivo/L014-4.png"
                }
            },

            new Producto
            {
                Id = "DEL015",
                Nombre = "SHEIN Cheerettes Mallas Deportivas De Color Sólido Con Bolsillo Para Teléfono",
                Categoria = "Leggins",
                Precio = 30.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S","L","XL" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L015.png",
                    "~/images/Deportivo/L015-1.png",
                    "~/images/Deportivo/L015-2.png",
                    "~/images/Deportivo/L015-3.png",
                    "~/images/Deportivo/L015-4.png"
                }
            },

            new Producto
            {
                Id = "DEL016",
                Nombre = "SHEIN Sport Gameset Leggings deportivos sin costuras de cintura alta de unicolor",
                Categoria = "Leggins",
                Precio = 27.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L016.png",
                    "~/images/Deportivo/L016-1.png",
                    "~/images/Deportivo/L016-2.png",
                    "~/images/Deportivo/L016-3.png",
                    "~/images/Deportivo/L016-4.png"
                }
            },

            new Producto
            {
                Id = "DEL017",
                Nombre = "SHEIN Sport Powerista Mallas deportivas de cintura alta con bloqueo de color",
                Categoria = "Leggins",
                Precio = 25.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Azul" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L017.png",
                    "~/images/Deportivo/L017-1.png",
                    "~/images/Deportivo/L017-2.png",
                    "~/images/Deportivo/L017-3.png",
                    "~/images/Deportivo/L017-4.png"
                }
            },

            new Producto
            {
                Id = "DEL018",
                Nombre = "SHEIN Pantalones con paneles de malla, leggings acampanados con control de abdomen y levantamiento de glúteos",
                Categoria = "Leggins",
                Precio = 30.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L018.png",
                    "~/images/Deportivo/L018-1.png",
                    "~/images/Deportivo/L018-2.png",
                    "~/images/Deportivo/L018-3.png",
                    "~/images/Deportivo/L018-4.png"
                }
            },

            new Producto
            {
                Id = "DEL019",
                Nombre = "SHEIN Sport Leggings de fitness casual al aire libre de ajuste delgado con cintura alta",
                Categoria = "Leggins",
                Precio = 29.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Verde Militar" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L019.png",
                    "~/images/Deportivo/L019-1.png",
                    "~/images/Deportivo/L019-2.png",
                    "~/images/Deportivo/L019-3.png",
                    "~/images/Deportivo/L019-4.png"
                }
            },

            new Producto
            {
                Id = "DEL020",
                Nombre = "SHEIN Sport Activina Pantalones Deportivos De Cintura Ancha De Color Sólido Para Mujeres",
                Categoria = "Leggins",
                Precio = 36.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Gris" },
                Talla = new List<string> { "S","M" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L020.png",
                    "~/images/Deportivo/L020-1.png",
                    "~/images/Deportivo/L020-2.png",
                    "~/images/Deportivo/L020-3.png",
                    "~/images/Deportivo/L020-4.png"
                }
            },

            new Producto
            {
                Id = "DEL021",
                Nombre = "SHEIN Powerista Pantalones De Jogging De Color Sólido Para Mujer Con Bolsillos",
                Categoria = "Leggins",
                Precio = 37.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "M","XL" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/L021.png",
                    "~/images/Deportivo/L021-1.png",
                    "~/images/Deportivo/L021-2.png",
                    "~/images/Deportivo/L021-3.png",
                    "~/images/Deportivo/L021-4.png"
                }
            },

            // CONJUNTOS Y ENTERIZOS DEPORTIVOS...

            new Producto
            {
                Id = "DECO01",
                Nombre = "SHEIN Sport Studio Conjunto de ropa deportiva",
                Categoria = "Conjuntos y Enterizos",
                Precio = 55.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Azul" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/CO01.png",
                    "~/images/Deportivo/CO01-1.png",
                    "~/images/Deportivo/CO01-2.png",
                    "~/images/Deportivo/CO01-3.png",
                    "~/images/Deportivo/CO01-4.png"
                }
            },

            new Producto
            {
                Id = "DECO02",
                Nombre = "SHEIN Sport Studio Rompers Deportivos De Manga Larga De Color Sólido Con Cuello Cuadrado",
                Categoria = "Conjuntos y Enterizos",
                Precio = 42.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/CO02.png",
                    "~/images/Deportivo/CO02-1.png",
                    "~/images/Deportivo/CO02-2.png",
                    "~/images/Deportivo/CO02-3.png",
                    "~/images/Deportivo/CO02-4.png"
                }
            },

            new Producto
            {
                Id = "DECO03",
                Nombre = "SHEIN VARSITIE Conjunto de top de tirantes y mallas para deportes",
                Categoria = "Conjuntos y Enterizos",
                Precio = 45.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/CO03.png",
                    "~/images/Deportivo/CO03-1.png",
                    "~/images/Deportivo/CO03-2.png",
                    "~/images/Deportivo/CO03-3.png",
                    "~/images/Deportivo/CO03-4.png"
                }
            },

            new Producto
            {
                Id = "DECO04",
                Nombre = "SHEIN Sport Easify Mono deportivo de mujer de unicolor con tirantes cruzados",
                Categoria = "Conjuntos y Enterizos",
                Precio = 50.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S","L" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/CO04.png",
                    "~/images/Deportivo/CO04-1.png",
                    "~/images/Deportivo/CO04-2.png",
                    "~/images/Deportivo/CO04-3.png",
                    "~/images/Deportivo/CO04-4.png"
                }
            },

            // FALDA SHORT DEPORTIVO...

            
            new Producto
            {
                Id = "DEF001",
                Nombre = "SHEIN Sport Studio Falda corta deportiva con cinturilla ancha",
                Categoria = "FaldaShort",
                Precio = 28.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Azul Marino" },
                Talla = new List<string> { "M" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/F001.png",
                    "~/images/Deportivo/F001-1.png",
                    "~/images/Deportivo/F001-2.png",
                    "~/images/Deportivo/F001-3.png",
                    "~/images/Deportivo/F001-4.png"
                }
            },

            new Producto
            {
                Id = "DEF002",
                Nombre = "SHEIN Sport Gameset Falda pantalón deportiva con estampado gráfico y bolsillo para teléfono",
                Categoria = "FaldaShort",
                Precio = 34.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Multicolor" },
                Talla = new List<string> { "M","XL" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/F002.png",
                    "~/images/Deportivo/F002-1.png",
                    "~/images/Deportivo/F002-2.png",
                    "~/images/Deportivo/F002-3.png",
                    "~/images/Deportivo/F002-4.png"
                }
            },

            // CASACAS Y POLERAS DEPORTIVAS...

            
            new Producto
            {
                Id = "DEP001",
                Nombre = "SHEIN Sudadera con cremallera hasta la mitad, con orificio para el pulgar, negra, con cremallera",
                Categoria = "Casacas y Poleras",
                Precio = 29.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "M","XL" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/P001.png",
                    "~/images/Deportivo/P001-1.png",
                    "~/images/Deportivo/P001-2.png",
                    "~/images/Deportivo/P001-3.png",
                    "~/images/Deportivo/P001-4.png"
                }
            },

            new Producto
            {
                Id = "DEP002",
                Nombre = "SHEIN VARSITIE básico de yoga de verano deportivo con top de manga larga",
                Categoria = "Casacas y Poleras",
                Precio = 27.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Negro" },
                Talla = new List<string> { "S" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/P002.png",
                    "~/images/Deportivo/P002-1.png",
                    "~/images/Deportivo/P002-2.png",
                    "~/images/Deportivo/P002-3.png",
                    "~/images/Deportivo/P002-4.png"
                }
            },

            new Producto
            {
                Id = "DEP003",
                Nombre = "SHEIN Musera Chaqueta ajustada de manga larga con cremallera completa y cuello alto en tejido suave",
                Categoria = "Casacas y Poleras",
                Precio = 45.00m,
                //PrecioAnterior = 55.00m,
                //Descuento = 50,
                Color = new List<string> { "Beige Oscuro" },
                Talla = new List<string> { "L" },
                Imagenes = new List<string>
                {
                    "~/images/Deportivo/P003.png",
                    "~/images/Deportivo/P003-1.png",
                    "~/images/Deportivo/P003-2.png",
                    "~/images/Deportivo/P003-3.png",
                    "~/images/Deportivo/P003-4.png"
                }
            },


            // Puedes seguir agregando más productos...
        };
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Productos(string categoria = "", int pagina = 1)
        {
            int tamanoPagina = 12;

            var productosFiltrados = string.IsNullOrEmpty(categoria)
                ? _productos
                : _productos.Where(p => p.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase)).ToList();

            int totalProductos = productosFiltrados.Count;

            var productosPagina = productosFiltrados
                .Skip((pagina - 1) * tamanoPagina)
                .Take(tamanoPagina)
                .ToList();

            var modelo = new PaginacionViewModel<Producto>
            {
                Items = productosPagina,
                PaginaActual = pagina,
                TotalPaginas = (int)Math.Ceiling((double)totalProductos / tamanoPagina)
            };

            ViewBag.Categoria = categoria;
            ViewBag.TotalProductos = totalProductos;

            return View(modelo);
        }

        public IActionResult DetalleProductos(string id)
        {
            var producto = _productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

    }
}
