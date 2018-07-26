using System;
using System.Linq.Expressions;

namespace Leandrovboas.CopaFilmes.Dominio.Extension
{
    public static class ObjectUtilities
    {
        public static string GetPropertyName<T>(Expression<Func<T>> propertyExpression) =>
            (propertyExpression.Body as MemberExpression).Member.Name;
    }
}
