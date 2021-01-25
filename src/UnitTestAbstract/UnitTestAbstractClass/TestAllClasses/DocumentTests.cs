namespace TestAllClasses
{
    using Implementation;
    using Moq;
    using Moq.Protected;
    using Xunit;
    
    public class DocumentTests
    {
        [Fact]
        public void Every_Document_Has_A_FullName()
        {
            // Arrange
            var mock = new Mock<Document>
            {
                CallBase = true
            };
            mock.Object.Name = "Invoice";
            mock
                .Protected()
                .Setup<string>("Extension")
                .Returns("pdf");
            
            // Act
            var documentFullName = mock.Object.GetDocumentFullName();

            // Assert
            Assert.Equal("Invoice.pdf", documentFullName);
        }

        [Fact]
        public void Excel_Document_Has_A_FullName()
        {
            // Arrange
            var subject = new ExcelDocument
            {
                Name = "Invoice"
            };

            // Act
            var fullname = subject.GetDocumentFullName();

            // Assert
            Assert.Equal("Invoice.xlsx", fullname);
        }

        [Fact]
        public void Word_Document_Has_A_FullName()
        {
            // Arrange
            var subject = new WordDocument
            {
                Name = "Invoice"
            };

            // Act
            var fullname = subject.GetDocumentFullName();

            // Assert
            Assert.Equal("Invoice.docx", fullname);
        }

        [Fact]
        public void Pdf_Document_Has_A_FullName()
        {
            // Arrange
            var subject = new PdfDocument
            {
                Name = "Invoice"
            };

            // Act
            var fullname = subject.GetDocumentFullName();

            // Assert
            Assert.Equal("Invoice.pdf", fullname);
        }
    }
}
