namespace Implementation
{
	public abstract class Document
    {
        public string Name { get; set; }

        protected abstract string Extension { get; }

        public string GetDocumentFullName()
        {
            return $"{Name}.{Extension}";
        }
    }
}
