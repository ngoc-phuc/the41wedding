namespace Dtos.Shared
{
    public class TypeNameDto : TypeNameDto<string>
    {
        public TypeNameDto()
        {
        }

        public TypeNameDto(string type, string name)
            : base(type, name)
        {
        }
    }

    public class TypeNameDto<T>
    {
        public string Type { get; set; }

        public T Name { get; set; }

        public TypeNameDto()
        {
        }

        public TypeNameDto(string type, T name)
        {
            Type = type;
            Name = name;
        }
    }
}