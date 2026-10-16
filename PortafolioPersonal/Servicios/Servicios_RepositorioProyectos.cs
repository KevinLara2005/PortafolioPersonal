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
                    Titulo = "TaskFlow Pro",
                    Descripcion = "Sistema de gestión de tareas con tableros Kanban, autenticación de usuarios y actualizaciones en tiempo real.",
                    Link = "#",
                    ImagenURL = "/imagenes/yo.jpg" // Usamos tu foto o la que tengas de placeholder por ahora
                },
                new ProyectoDTO
                {
                    Titulo = "EcoTrack Dashboard",
                    Descripcion = "Panel de control interactivo para visualizar métricas de consumo energético utilizando gráficos dinámicos.",
                    Link = "#",
                    ImagenURL = "/imagenes/yo.jpg"
                },
                new ProyectoDTO
                {
                    Titulo = "DevBlog API",
                    Descripcion = "API RESTful completa con documentación Swagger, gestión de comentarios y sistema de roles (Admin/Autor).",
                    Link = "#",
                    ImagenURL = "/imagenes/yo.jpg"
                }
            };
        }
    }
}