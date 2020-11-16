namespace CafeManagementSystem.model
{
    class Product
    {
        private int productID;
        private string productName;
        private double price;
        private int quantity;
        private string image;
        private string description;
        private int categoryID;

        public Product(string productName, double price, int quantity, string image, string description, int categoryID)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
            this.image = image;
            this.description = description;
            this.categoryID = categoryID;
        }
        public Product(int productID, string productName, double price, int quantity, string image, string description, int categoryID)
        {
            this.productID = productID;
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
            this.image = image;
            this.description = description;
            this.categoryID = categoryID;
        }

        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Image { get => image; set => image = value; }
        public string Description { get => description; set => description = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
    }
}
