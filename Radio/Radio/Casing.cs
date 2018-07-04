namespace Radio
{
    public class Casing : ICasing
    {
        private readonly string _material;

        public Casing(string material)
        {
            _material = material;
        }

        public string TypeOfMaterial()
        {
            return "Material Used :" + _material;
        }
    }
}
