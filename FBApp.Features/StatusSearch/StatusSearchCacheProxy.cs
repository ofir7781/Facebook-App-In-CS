using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FBApp.Features
{
    internal class StatusSearchCacheProxy : IStatusSearch
    {
        private StatusSearch m_StatusSearch;
        private string[] m_LastThreeUsedTexts;
        private List<Tuple<User, Status>>[] m_LastThreeUsedTextsStatuses;
        private List<Tuple<User, Status>> m_CurrentUserTextReleventStatuses;
        private int m_RecentlyUsedTextIndexNeedToChange;

        public StatusSearchCacheProxy()
        {
            m_LastThreeUsedTexts = new string[3];
            m_LastThreeUsedTextsStatuses = new List<Tuple<User, Status>>[3];
            m_RecentlyUsedTextIndexNeedToChange = 0;
        }

        public List<Tuple<User, Status>> GetAllStatuses(string i_StringToSearch, List<User> i_Friends)
        {
            if(m_StatusSearch == null)
            {
                m_StatusSearch = new StatusSearch();
            }

            bool isNewTextWasRecentlyUsed = false;

            isNewTextWasRecentlyUsed = checkAndUpdateIfNewTextWasRecentlyUsed(i_StringToSearch);

            if(!isNewTextWasRecentlyUsed)
            {
                m_CurrentUserTextReleventStatuses = m_StatusSearch.GetAllStatuses(i_StringToSearch, i_Friends);
                if(m_CurrentUserTextReleventStatuses.Count > 0)
                {
                    updateLastThreeUsedTextsStatuses(i_StringToSearch);
                }
            }

            return m_CurrentUserTextReleventStatuses;
        }

        private void updateLastThreeUsedTextsStatuses(string i_StringToSearch)
        {
            if(m_RecentlyUsedTextIndexNeedToChange == 3)
            {
                m_RecentlyUsedTextIndexNeedToChange = 0;
            }

            m_LastThreeUsedTexts[m_RecentlyUsedTextIndexNeedToChange] = i_StringToSearch;
            m_LastThreeUsedTextsStatuses[m_RecentlyUsedTextIndexNeedToChange] = m_CurrentUserTextReleventStatuses;
            m_RecentlyUsedTextIndexNeedToChange++;
        }

        private bool checkAndUpdateIfNewTextWasRecentlyUsed(string i_StringToSearch)
        {
            bool checkIfTextWasRecentlyUsed = false;
            for (int i = 0; i < m_LastThreeUsedTexts.Length; i++)
            {
                if (i_StringToSearch.Equals(m_LastThreeUsedTexts[i]) == true && !checkIfTextWasRecentlyUsed)
                {
                    checkIfTextWasRecentlyUsed = true;
                    m_CurrentUserTextReleventStatuses = m_LastThreeUsedTextsStatuses[i];
                }
            }

            return checkIfTextWasRecentlyUsed;
        }

        public List<User> GetAllUserFriends(User i_User)
        {
            List<User> userFriendsList = new List<User>();
            foreach (User friend in i_User.Friends)
            {
                userFriendsList.Add(friend);
            }

            return userFriendsList;
        }
    }
}