namespace PrototypePattern
{
    public class Ford : BasicCar
    {

        public Ford(string modelName)
        {
            ModelName = modelName;
        }

        public override BasicCar Clone()
        {
            return (Ford) this.MemberwiseClone();
        }

    }
}
