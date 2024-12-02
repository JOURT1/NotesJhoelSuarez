namespace Notes.Models
{
    public class About
    {
        public string Title { get; set; } = "Acerca de la App";
        public string Version { get; set; } = "1.0.0";
        public string Message { get; set; } = "Información básica de la app.";
        public string MoreInfoUrl { get; set; } = "https://aka.ms/maui"; // URL válida
    }
}
