using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionsStudy.Extensions.Post
{
    public static class Extensions
    {
        public static IEnumerable<Entities.Post> Popular(this IEnumerable<Entities.Post> PostSource)
        {
            return from Post in PostSource
                   where Post.Votes > 100
                   select Post;
        }

        public static IEnumerable<Entities.Post> Latest(this IEnumerable<Entities.Post> PostSource)
        {
            return from Post in PostSource
                   where Post.CreatedAt > DateTime.Today.AddMonths(-1)
                   select Post;
        }
    }
}