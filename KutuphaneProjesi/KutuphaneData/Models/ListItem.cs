namespace KutuphaneData.Models
{
    public class ListItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
