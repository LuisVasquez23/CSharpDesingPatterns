namespace BuilderPattern
{
    public class Director
    {
        private IBuilder? _builder;

        // A series of steps-in real life, steps are complex.
        public void Construct(IBuilder builder) {
           
            this._builder = builder;
            
            builder.StartUpOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadlights();
            builder.EndOperations();
        }
    }
}
