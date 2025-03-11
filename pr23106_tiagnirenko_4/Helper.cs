using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static pr23106_tiagnirenko_4.DbContext;

namespace pr23106_tiagnirenko_4
{
    internal class Helper
    {
        public static MyDbContext GetContext()
        {
            return new MyDbContext();
        }

        public static List<Group> GetGroups(string searchTitle, string sortType)
        {
            using (var context = GetContext())
            {
                var groups = context.Groups.AsQueryable();

                if (!string.IsNullOrEmpty(searchTitle))
                {
                    groups = groups.Where(g => g.Title.Contains(searchTitle));
                }

                switch (sortType)
                {
                    case "По убыванию названия группы":
                        groups = groups.OrderByDescending(g => g.Title);
                        break;
                    case "По возрастанию названия группы":
                        groups = groups.OrderBy(g => g.Title);
                        break;
                }

                return groups.ToList();
            }
        }
    }
}
