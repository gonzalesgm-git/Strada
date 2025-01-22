using Moq;
using Strada.Application.Features.Users.Commands;
using Strada.Database.Repositories;
using Strada.Domain.Models.Users;

namespace Strada.Tests.Features.Users
{
    public class CreateUserCommandHandlerTests
    {

        [Fact]
        public async Task Handle_Should_Save_ValidUser()
        {
            //Arrange
            var command = new CreateUserCommand()
            {
                Email = "gerald@test.com",
                FirstName = "Gerald",
                LastName = "Gonzales"
            };

            var user = new User()
            {
                Email = command.Email,
                FirstName = command.FirstName,
                LastName = command.LastName,
            };

            var mockUserRepo = new Mock<IRepository<User>>();

            // Act
            var repo = new CreateUserCommandHandler(mockUserRepo.Object);
            var results = await repo.Handle(command, CancellationToken.None);

            // Assert
            Assert.NotNull(results);
            Assert.True(results.Data.Successful);
        }

    }
}
