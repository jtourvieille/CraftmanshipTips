namespace TestOnlyConcreteClasses
{
    using Implementation;
    using Xunit;

    public class WordDocumentTests
    {
        [Fact]
        public void Word_Document_Has_A_FullName()
        {
            // Arrange
            var subject = new WordDocument
            {
                Name = "Invoice"
            };

            // Act
            var extension = subject.GetDocumentFullName();

            // Assert
            Assert.Equal("Invoice.docx", extension);
        }
    }
}
