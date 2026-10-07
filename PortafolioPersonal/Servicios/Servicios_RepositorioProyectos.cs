using PortafolioPersonal.Models;

namespace PortafolioPersonal.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>() {
                new ProyectoDTO
                {
                    Titulo = "Amazon",
                    Descripcion = "E-commerce realizado en ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenURL = "/imagenes/amazon.PNG"
                },
                new ProyectoDTO
                {
                    Titulo = "New York Times",
                    Descripcion = "Páginas de noticias en React",
                    Link = "https://nytimes.com",
                    ImagenURL = "/imagenes/nyt.PNG"
                },
                new ProyectoDTO
                {
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir en comunidades",
                    Link = "https://reddit.com",
                    ImagenURL = "/imagenes/reddit.PNG"
                }
            };
        }
    }
}