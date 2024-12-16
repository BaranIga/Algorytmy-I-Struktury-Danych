namespace dsa.utils
{
    class AlgComboItem
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public AlgComboItem(int id, string text)
        {
            Id = id;
            Text = text;
        }

        public AlgComboItem() { }
    }
}
