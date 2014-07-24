using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using StructureMap.Query;

namespace eManager.Web.Helper
{
    public static class SplLabel 
    {
        public static MvcHtmlString SplLabelFor<TModel,TValue>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TValue>> expression)
        {
            var exp = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);

            return MvcHtmlString.Create(String.Format("<label for='{0}'>{1}</label>", exp.PropertyName,
                ExpressionHelper.GetExpressionText(expression)));
        }
    }
}