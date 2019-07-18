using System.Collections.Generic;

namespace UnitTesting.MyFace
{
    public class MyFaceClient : IMyFaceClient
    {
        public IEnumerable<WallPost> WallPosts(string username)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IMyFaceClient
    {
        IEnumerable<WallPost> WallPosts(string username);
    }
}