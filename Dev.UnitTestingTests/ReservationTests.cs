
using Dev.UnitTesting.Fundamentals;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Dev.UnitTestingTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true});
            //Assert
            Assert.That(result, Is.True);

        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellindTheReservation_ReturnsTrue()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation {MadeBy = user };
            

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.That(result, Is.True);

        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellindTheReservation_ReturnsFalse()
        {
            //Arrange            
            var reservation = new Reservation {MadeBy = new User() };


            //Act
            var result = reservation.CanBeCancelledBy(new User());

            //Assert
            Assert.That(result, Is.False);

        }
    }
}