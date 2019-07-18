using System;
using System.Linq;

namespace UnitTesting.MyFace
{
    public class MyFaceWall
    {
        private readonly IMyFaceClient _myFaceClient;

        public MyFaceWall(IMyFaceClient myFaceClient)
        {
            _myFaceClient = myFaceClient;
        }

        public int GetNumberOfPostsOnWall(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentNullException(nameof(username));
            }

            return _myFaceClient.WallPosts(username)
                .Count();
        }
    }

    public interface IMyFaceWall
    {
        int GetNumberOfPostsOnWall(string username);
    }
}