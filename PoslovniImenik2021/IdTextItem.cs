namespace PoslovniImenik
{
    public class IdTextItem
    {
        public IdTextItem(string text, long id)
        {
            this.Text = text;
            this.Id = id;
        }

        public override string ToString()
        {
            return this.Text;
        }

        public long Id { get; set; }
        public string Text { get; set; }
    }

}
