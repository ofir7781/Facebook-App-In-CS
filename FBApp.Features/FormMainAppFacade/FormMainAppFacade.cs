using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FBApp.Features
{
    public class FormMainAppFacade
    {
        private User m_LoggedInUser;
        private TimelinePosts m_TimelinePosts;
        private IStatusSearch m_IStatusSearch;
        private DirectorAnalyzer m_DirectorAnalyzer;
        private IBuilderAnalyzer m_IStatusAnalyzerBuilder;

        public FormMainAppFacade(User i_User)
        {
            m_LoggedInUser = i_User;
        }

        public List<Post> GetAllUserPosts()
        {
            if (m_TimelinePosts == null)
            {
                m_TimelinePosts = new TimelinePosts(m_LoggedInUser);
            }

            return m_TimelinePosts.GetAllUserPosts();
        }

        public void PostStatus(string i_TextToPost)
        {
            if (m_TimelinePosts == null)
            {
                m_TimelinePosts = new TimelinePosts(m_LoggedInUser);
            }

            m_TimelinePosts.MakeNewPost(i_TextToPost);
        }

        public List<Tuple<User, Status>> SearchInFriendsStatuses(string i_TextToSearch)
        {
            if (m_IStatusSearch == null)
            {
                m_IStatusSearch = new StatusSearchCacheProxy();
            }

            StatusSearchCacheProxy statusSearchCacheProxy = m_IStatusSearch as StatusSearchCacheProxy;
            List<User> userFriends = statusSearchCacheProxy.GetAllUserFriends(m_LoggedInUser);
            return statusSearchCacheProxy.GetAllStatuses(i_TextToSearch, userFriends);
        }

        public string GetStatusAnalysis()
        {
            if (m_DirectorAnalyzer == null)
            {
                m_DirectorAnalyzer = new DirectorAnalyzer();
            }

            if (m_IStatusAnalyzerBuilder == null)
            {
                m_IStatusAnalyzerBuilder = new StatusAnalyzerBuilder(m_LoggedInUser);
            }

            m_DirectorAnalyzer.Construct(m_IStatusAnalyzerBuilder);
            return m_IStatusAnalyzerBuilder.GetProduct().TextAnalysis;
        }

        public User GetTheUserWhoFollowedTheMost()
        {
            return m_IStatusAnalyzerBuilder.GetProduct().MostFollowerUser;
        }
    }
}
