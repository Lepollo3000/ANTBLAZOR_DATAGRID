﻿using System.Reflection;
using System.Text;
using System.Linq.Dynamic.Core;
using ANTBLAZOR_DATAGRID.Shared.Models;

namespace ANTBLAZOR_DATAGRID.Server.Utils.Repository
{
    public static class RepositoryProductExtensions
    {
        public static IQueryable<Product> Search(this IQueryable<Product> Products, string searchTearm)
        {
            if (string.IsNullOrWhiteSpace(searchTearm))
                return Products;

            var lowerCaseSearchTerm = searchTearm.Trim().ToLower();

            return Products.Where(p => p.Name.ToLower().Contains(lowerCaseSearchTerm));
        }

        public static IQueryable<Product> Sort(this IQueryable<Product> Products, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return Products.OrderBy(e => e.Name);

            var orderParams = orderByQueryString.Trim().Split(',');
            var propertyInfos = typeof(Product).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var orderQueryBuilder = new StringBuilder();

            foreach (var param in orderParams)
            {
                if (string.IsNullOrWhiteSpace(param))
                    continue;

                var propertyFromQueryName = param.Split(" ")[0];
                var objectProperty = propertyInfos.FirstOrDefault(pi => 
                    pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase)
                );

                if (objectProperty == null)
                    continue;

                var direction = param.EndsWith(" desc") ? "descending" : "ascending";
                orderQueryBuilder.Append($"{objectProperty.Name} {direction}, ");
            }

            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');
            if (string.IsNullOrWhiteSpace(orderQuery))
                return Products.OrderBy(e => e.Name);

            return Products.OrderBy(orderQuery);
        }
    }
}
