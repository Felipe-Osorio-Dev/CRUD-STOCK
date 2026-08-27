using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Product
{
    [Index(nameof(Ean), IsUnique = true)]
    public class ProductModel
    {
        public long Id { get; set; }

        [Column("Nome_Produto")]
        public string Name { get; set; }

        [Column("Cod_Produto")]
        public string Ean { get; set; }

        [Column("Quantidade")]
        public int Amount { get; set; }
        public bool IsEnable { get; set; }
        public DateOnly CreatedAt { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);

        [Column("Validade")]
        public DateOnly Validate { get; set; }
    }
}
