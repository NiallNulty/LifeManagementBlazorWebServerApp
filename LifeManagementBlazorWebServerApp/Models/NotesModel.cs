using System.ComponentModel.DataAnnotations.Schema;

namespace LifeManagementBlazorWebServerApp.Models
{
    public class NotesModel
    {
        public string Title { get; set; }
        public string Note { get; set; }
    }
}
