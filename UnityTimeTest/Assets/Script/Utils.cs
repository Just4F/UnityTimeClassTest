using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public static class Utils {

    public static string Nameof<T>(System.Linq.Expressions.Expression<Func<T>> exp)
    {
        return ((System.Linq.Expressions.MemberExpression)exp.Body).Member.Name;
    }

    // 直接调用 T 的Type可能认不到需要显式指定<T>
    public static string Nameof<T>(System.Linq.Expressions.Expression<Func<T, T>> exp)
    {
        return ((System.Linq.Expressions.MemberExpression)exp.Body).Member.Name;
    }

    /// <summary>
    /// 扩展 获取变量名称(字符串)
    /// lambda+反射实现, 比较慢  相当于C#6中的nameof
    /// </summary>
    /// <param name="var_name"></param>
    /// <param name="exp"></param>
    /// <returns>return string</returns>
    public static string Nameof<T>(this T var_name, System.Linq.Expressions.Expression<Func<T, T>> exp)
    {
        return ((System.Linq.Expressions.MemberExpression)exp.Body).Member.Name;
    }

    public static string GetNameValueFormart<T>(System.Linq.Expressions.Expression<Func<T, T>> exp,
    string format = "{0} : {1}")
    {
        var value = exp.Compile().Invoke(default(T));
        return string.Format(format, Nameof(exp), value);
    }

    public static string GetNameValueFormart<T>(this T var_name, System.Linq.Expressions.Expression<Func<T, T>> exp,
        string format = "{0} : {1}")
    {
        return string.Format(format, Nameof(exp), var_name.ToString());
    }

    public static string GetNameValueFormart1<T>(System.Linq.Expressions.Expression<Func<T, T>> exp)
    {
        return GetNameValueFormart(exp, "{0} : {1}, ");
    }

    public static string GetNameValueFormart1<T>(this T var_name, System.Linq.Expressions.Expression<Func<T, T>> exp)
    {
        return var_name.GetNameValueFormart(exp, "{0} : {1}, ");        
    }
}
