using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FBApp.Features
{
    internal class TimelinePosts
    {
        private User m_LoggedInUser;

        public TimelinePosts(User i_User)
        {
            m_LoggedInUser = i_User;
        }

        public List<Post> GetAllUserPosts()
        {
            List<Post> userPosts = new List<Post>();
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    userPosts.Add(post);
                }
            }

            return userPosts;
        }

        public void MakeNewPost(string i_TextToPost)
        {
            try
            {
                m_LoggedInUser.PostStatus(i_TextToPost);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}