using System.Collections.Generic;
using Moq;
using UnitTesting.MyFace;
using Xunit;

namespace UnitTesting.Tests.MyFace
{
    public class TestMyFaceWall
    {
        [Fact]
        public void TwoPostsOnWallReturnTwoPosts()
        {
            // arrange
            var client = new Mock<IMyFaceClient>();
            var myFaceWall = new MyFaceWall(client.Object);
            var twoWallPosts = new List<WallPost>
            {
                new WallPost
                {
                    Poster = "xzibit",
                    WallOwner = "mark wallberg",
                    Content = "You could drink whole milk if you wanted to."
                },
                new WallPost
                {
                    Poster = "mstewart",
                    WallOwner = "mark wallberg",
                    Content = "Watermelon is the summer is delicious."
                }
            };
            client.Setup(c => c.WallPosts("mark wallberg"))
                .Returns(twoWallPosts)
                .Verifiable();

            // act
            var posts = myFaceWall.GetNumberOfPostsOnWall("mark wallberg");

            // assert
            Assert.Equal(twoWallPosts.Count, posts);
            client.Verify();
        }
    }
}