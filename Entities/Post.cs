using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExtensionsStudy.Entities
{
    [Table("posts")]
    public class Post
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("votes")]
        public int Votes { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}