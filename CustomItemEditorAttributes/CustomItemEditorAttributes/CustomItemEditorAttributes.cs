namespace CustomItemEditorAttributes
{
    [AttributeUsage(AttributeTargets.All)]
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
        public bool MultiSelection { get; set; }
        public CustomSelectionAttribute(string attrName, bool multiSelection = false) { DefaultType = attrName; MultiSelection = multiSelection; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class CustomImporterAttribute : Attribute
    {
        public object[] ApplyTo { get; set; }
        public string Description { get; set; }
        public CustomImporterAttribute(string descr, object[] applyTo) { Description = descr; ApplyTo = applyTo;}
    }
}
