namespace PrototypePattern
{
    public abstract class BasicCar
    {
        public string? ModelName { get; set; }
        public int Price { get; set; }
        public static int SetPrice()
        {
            int price = 0;
            Random random = new Random();
            price = random.Next(20000 , 50000);
            return price;
        }

        public abstract BasicCar Clone();
    }
}
