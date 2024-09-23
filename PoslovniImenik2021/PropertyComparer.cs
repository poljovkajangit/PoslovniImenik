using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PoslovniImenik
{
    public class PropertyComparer<T> : IComparer<T>
    {
        // Fields
        private PropertyDescriptor _property;
        private ListSortDirection _direction;

        // Methods
        public PropertyComparer(PropertyDescriptor property, ListSortDirection direction)
        {
            this._property = property;
            this._direction = direction;
        }

        public int Compare(T xWord, T yWord)
        {
            object propertyValue = this.GetPropertyValue(xWord, this._property.Name);
            object yValue = this.GetPropertyValue(yWord, this._property.Name);
            if (this._direction == ListSortDirection.Ascending)
            {
                return this.CompareAscending(propertyValue, yValue);
            }
            return this.CompareDescending(propertyValue, yValue);
        }

        private int CompareAscending(object xValue, object yValue)
        {
            int num;
            if ((xValue == null) && (yValue == null))
            {
                return 0;
            }
            if (xValue == null)
            {
                return -1;
            }
            if (yValue == null)
            {
                return 1;
            }
            if (xValue is IComparable)
            {
                num = ((IComparable)xValue).CompareTo(yValue);
            }
            else if (xValue.Equals(yValue))
            {
                num = 0;
            }
            else
            {
                num = xValue.ToString().CompareTo(yValue.ToString());
            }
            return num;
        }

        private int CompareDescending(object xValue, object yValue)
        {
            return (this.CompareAscending(xValue, yValue) * -1);
        }

        public bool Equals(T xWord, T yWord)
        {
            return xWord.Equals(yWord);
        }

        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }

        private object GetPropertyValue(T value, string property)
        {
            Type type = typeof(T);
            return value.GetType().GetProperty(property).GetValue(value, null);
        }
    }
}
