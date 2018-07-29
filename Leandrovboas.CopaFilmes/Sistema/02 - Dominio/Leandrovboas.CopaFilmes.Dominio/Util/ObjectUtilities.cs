using System;
using System.Linq.Expressions;

namespace Leandrovboas.CopaFilmes.Dominio.Extension
{
    public static class ObjectUtilities
    {
        /// <summary>
        /// Recupera o noma da propriedade
        /// </summary>
        /// <typeparam name="T">Tipo do objeto</typeparam>
        /// <param name="propertyExpression">Expressao para propriedade</param>
        /// <returns>O Nome da propriedade</returns>
        public static string GetPropertyName<T>(Expression<Func<T>> propertyExpression) =>
            (propertyExpression.Body as MemberExpression).Member.Name;
    }
}
