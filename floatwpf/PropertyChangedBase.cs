using System.ComponentModel;
using System.Linq.Expressions;
using System;

public abstract class PropertyChangedBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    public void NotifyOfAllPropertiesChange()
    {
        var handler = PropertyChanged;
        if (handler != null)
            handler(this, new PropertyChangedEventArgs(null));
    }

    public void NotifyOfPropertyChange(string propertyName)
    {
        var handler = PropertyChanged;
        if (handler != null)
            handler(this, new PropertyChangedEventArgs(propertyName));
    }

    public void NotifyOfPropertyChange<TProperty>(Expression<Func<TProperty>> property)
    {
        var lambda = (LambdaExpression)property;

        MemberExpression memberExpression;
        if (lambda.Body is UnaryExpression)
        {
            var unaryExpression = (UnaryExpression)lambda.Body;
            memberExpression = (MemberExpression)unaryExpression.Operand;
        }
        else memberExpression = (MemberExpression)lambda.Body;

        NotifyOfPropertyChange(memberExpression.Member.Name);
    }
}