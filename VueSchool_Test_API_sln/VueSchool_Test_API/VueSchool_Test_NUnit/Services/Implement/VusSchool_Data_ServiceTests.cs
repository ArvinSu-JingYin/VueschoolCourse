using Moq;
using VueSchool_Test_BusinessLayer.ServiceModel.DTO;
using VueSchool_Test_BusinessLayer.Services.Interface;

namespace VueSchool_Test_BusinessLayer.Services.Implement.Tests
{
    // This is a test class using the NUnit framework
    [TestFixture()]
    public class VusSchool_Data_ServiceTests
    {
        // Declare a Mock object to simulate the IVusSchool_Data_Service interface
        private Mock<IVusSchool_Data_Service> _mockService;

        // The SetUp method is called before each test method is executed
        [SetUp]
        public void Setup()
        {
            // Initialize the Mock object
            _mockService = new Mock<IVusSchool_Data_Service>();
        }

        // This is a test method to test the GetTravelData method
        [Test()]
        public void GetTravelDataTest()
        {
            // Arrange: Prepare the test data
            // Input parameters
            var num = "1"; 

            // Expected result
            var expectedData = new List<Destination_DTOModel>
            {
                new Destination_DTOModel { Id = 1, name = "Destination 1", }
            }; 

            // Set the behavior of the Mock object, when the GetTravelData method is called, return the expected result
            _mockService.Setup(service => service.GetTravelData(num)).Returns(expectedData);

            // Act: Execute the test method
            var result = _mockService.Object.GetTravelData(num);

            // Assert: Validate the result
            // Validate if the result is the same as expected   
            Assert.That(result, Is.EqualTo(expectedData)); 
            // Validate the size of the result collection
            Assert.That(result.Count(), Is.EqualTo(1)); 
            // Validate the name property of the first element in the result collection
            Assert.That(result.First().name, Is.EqualTo("Destination 1")); 
        }
    }
}