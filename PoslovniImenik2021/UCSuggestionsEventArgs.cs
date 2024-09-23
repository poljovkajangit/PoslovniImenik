using System;

namespace PoslovniImenik
{
    public class UCSuggestionsEventArgs : EventArgs
    {
        public UCSuggestionsEventArgs()
        {
        }

        public UCSuggestionsEventArgs(string selected, string normalized)
        {
            this.SelectedValue = selected;
            this.NormalizedValue = normalized;
        }
        public string SelectedValue { get; set; }

        public string NormalizedValue { get; set; }
    }

    public delegate void UCSuggestionsEventHandler(UCSuggestionsEventArgs args);


   

}
