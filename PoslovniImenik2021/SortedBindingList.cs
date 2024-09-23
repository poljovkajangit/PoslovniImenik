using System.Collections.Generic;
using System.ComponentModel;

namespace PoslovniImenik
{
    public class SortedBindingList<T> : BindingList<T>
    {
        // Fields
        private bool _isSorted;
        private PropertyDescriptor _sortProperty;
        private ListSortDirection _sortDirection;

        // Methods
        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {
            List<T> items = base.Items as List<T>;
            if (items != null)
            {
                PropertyComparer<T> comparer = new PropertyComparer<T>(property, direction);
                items.Sort(comparer);
                this._isSorted = true;
            }
            else
            {
                this._isSorted = false;
            }
            this._sortProperty = property;
            this._sortDirection = direction;
            this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {
            this._isSorted = false;
            this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        // Properties
        protected override bool SupportsSortingCore
        {
            get
            {
                return true;
            }
        }

        protected override ListSortDirection SortDirectionCore
        {
            get
            {
                return this._sortDirection;
            }
        }

        protected override PropertyDescriptor SortPropertyCore
        {
            get
            {
                return this._sortProperty;
            }
        }

        protected override bool IsSortedCore
        {
            get
            {
                return this._isSorted;
            }
        }
    }
}
