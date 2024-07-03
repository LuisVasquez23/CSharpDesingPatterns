namespace PrototypePattern
{
    public class Nano : BasicCar
    {

        public Nano(string modelName) {
            ModelName = modelName;
        }

        public override BasicCar Clone()
        {
            return (Nano) this.MemberwiseClone(); // Shallow clone
        }

    }
}
