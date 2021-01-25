namespace TestOnlyConcreteClasses
{
    using Implementation;
    using Xunit;

    public class ExcelDocumentTests
    {
        [Fact]
        public void Excel_Document_Has_A_FullName()
        {
            // Arrange
            var subject = new ExcelDocument
            {
                Name = "Invoice"
            };

            // Act
            var extension = subject.GetDocumentFullName();

            // Assert
            Assert.Equal("Invoice.xlsx", extension);
        }
    }
}
