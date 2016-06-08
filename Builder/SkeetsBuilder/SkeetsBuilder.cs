namespace Builder.SkeetsBuilder
{
    /// <summary>
    /// From Jon Skeet's C# Design Strategies course.
    /// Can build a shy class
    /// </summary>
    public sealed class ShyClass
    {
        private readonly string name;

        private ShyClass(Builder builder)
        {
            this.name = builder.Name;
        }

        public override string ToString()
        {
            return $"Shy class: Name = {name}";
        }

        public sealed class Builder
        {
            public string Name { get; set; }

            public ShyClass Build()
            {
                return new ShyClass(this);
            }
        }

    }
}