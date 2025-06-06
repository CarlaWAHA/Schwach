using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
   public class Comment
{
    public int Id { get; set; }

    [Required]
    public string Author { get; set; } = string.Empty;

    [Required]
    public string Content { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int MovieId { get; set; }

    public int? ParentId { get; set; } // ✅ pour la gestion des réponses
}


}
