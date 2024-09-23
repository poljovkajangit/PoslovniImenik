using System.Collections.Generic;

namespace PoslovniImenik
{
    public static class ExtensionAttributesClass
    {
        public static void ReplaceContent<T>(this SortedBindingList<T> list, ICollection<T> collection)
        {
            list.RaiseListChangedEvents = false;
            list.Clear();
            foreach (T local in collection)
            {
                list.Add(local);
            }
            list.RaiseListChangedEvents = true;
            list.ResetBindings();
        }
    }
}
