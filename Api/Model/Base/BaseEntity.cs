using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
