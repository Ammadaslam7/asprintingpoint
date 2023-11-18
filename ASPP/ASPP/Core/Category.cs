namespace ASPP.Core
{
    internal class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Category(int iD, string name )        {
            ID = iD;
            Name = name;
        }

        public Category(string name) : this(-1, name) { }
    }
}
