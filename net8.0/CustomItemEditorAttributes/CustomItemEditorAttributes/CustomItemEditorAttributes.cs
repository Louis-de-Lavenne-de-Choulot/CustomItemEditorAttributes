namespace CustomItemEditorAttributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class CustomDescriptionAttribute : Attribute
    {
        public string Description { get; set; }
        public CustomDescriptionAttribute(string description) => Description = description;
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class DefaultStateAttribute : Attribute
    {
        public object DefaultState { get; set; }
        public DefaultStateAttribute(object attrType) => DefaultState = attrType;
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class CustomSelectionAttribute : Attribute
    {
        public string DefaultType { get; set; }
        public CustomSelectionAttribute(string attrName) => DefaultType = attrName;
    }
}
