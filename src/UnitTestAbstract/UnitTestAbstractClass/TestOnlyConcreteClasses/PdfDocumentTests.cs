namespace TestOnlyConcreteClasses
{
    using Implementation;
    using Xunit;

    public class PdfDocumentTests
    {
        [Fact]
        public void Word_Document_Has_A_FullName()
        {
            // Arrange
            var subject = new PdfDocument
            {
                Name = "Invoice"
            };

            // Act
            var extension = subject.GetDocumentFullName();

            // Assert
            Assert.Equal("Invoice.pdf", extension);
        }
    }
}
