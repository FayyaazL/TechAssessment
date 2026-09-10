using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;
using TechAssessment.Core.Entities;
using TechAssessment.Repositories.Interfaces;
using TechAssessment.Services;
using Xunit;

namespace TechAssessment.Services.Tests
{
    public class AttendeeServiceTests
    {
        [Fact]
        public async Task CreateAsync_CallsRepositoryAddAsync()
        {
            var repo = new Mock<ICalendarEntityRepository<Attendee>>();
            var service = new AttendeeService(repo.Object);
            var attendee = new Attendee { Id = 1, Name = "Alice", Email = "a@a.com" };

            await service.CreateAsync(attendee);

            repo.Verify(r => r.AddAsync(attendee), Times.Once);
        }

        [Fact]
        public async Task DeleteAsync_WhenEntityExists_CallsRepositoryDeleteAsync()
        {
            var repo = new Mock<ICalendarEntityRepository<Attendee>>();
            var attendee = new Attendee { Id = 2, Name = "Bob", Email = "b@b.com" };
            repo.Setup(r => r.GetByIdAsync(2)).ReturnsAsync(attendee);

            var service = new AttendeeService(repo.Object);

            await service.DeleteAsync(2);

            repo.Verify(r => r.DeleteAsync(attendee), Times.Once);
        }

        [Fact]
        public async Task DeleteAsync_WhenEntityDoesNotExist_DoesNotCallDelete()
        {
            var repo = new Mock<ICalendarEntityRepository<Attendee>>();
            repo.Setup(r => r.GetByIdAsync(99)).ReturnsAsync((Attendee?)null);

            var service = new AttendeeService(repo.Object);

            await service.DeleteAsync(99);

            repo.Verify(r => r.DeleteAsync(It.IsAny<Attendee>()), Times.Never);
        }

        [Fact]
        public async Task GetAllAsync_ReturnsRepositoryResults()
        {
            var repo = new Mock<ICalendarEntityRepository<Attendee>>();
            var list = new List<Attendee>
            {
                new Attendee { Id = 1, Name = "A", Email = "a@a.com" },
                new Attendee { Id = 2, Name = "B", Email = "b@b.com" }
            };
            repo.Setup(r => r.GetAllAsync()).ReturnsAsync(list);

            var service = new AttendeeService(repo.Object);

            var result = await service.GetAllAsync();

            Assert.Same(list, result);
        }

        [Fact]
        public async Task GetByIdAsync_ReturnsRepositoryResult()
        {
            var repo = new Mock<ICalendarEntityRepository<Attendee>>();
            var attendee = new Attendee { Id = 3, Name = "C", Email = "c@c.com" };
            repo.Setup(r => r.GetByIdAsync(3)).ReturnsAsync(attendee);

            var service = new AttendeeService(repo.Object);

            var result = await service.GetByIdAsync(3);

            Assert.Same(attendee, result);
        }

        [Fact]
        public async Task UpdateAsync_CallsRepositoryUpdateAsync()
        {
            var repo = new Mock<ICalendarEntityRepository<Attendee>>();
            var attendee = new Attendee { Id = 4, Name = "D", Email = "d@d.com" };

            var service = new AttendeeService(repo.Object);

            await service.UpdateAsync(attendee);

            repo.Verify(r => r.UpdateAsync(attendee), Times.Once);
        }
    }
}