using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FBApp.Features
{
    internal class StatusAnalyzerBuilder : IBuilderAnalyzer
    {
        private User m_LoggedInUser;
        private User m_UserWhoLikedTheMost;
        private List<Status> m_AllStatuses;
        private AnalysisProduct m_Product;

        private enum eStatusFilter
        {
            ByLikes,
            ByComments,
        }

        public StatusAnalyzerBuilder(User m_User)
        {
            m_LoggedInUser = m_User;
            m_Product = new AnalysisProduct();
        }

        public void BuildLikesAnalyzer()
        {
            List<Status> mostLikedStatuses = getListOfMostLikedStatuses();
            m_Product.TextAnalysis += "-------------------------------------------------------------------------------------------------------------------------------------------\n";
            m_Product.TextAnalysis += string.Format("Your Most Liked Statuses Has {0} Likes:\n", mostLikedStatuses[0].LikedBy.Count);
            m_Product.TextAnalysis += "-------------------------------------------------------------------------------------------------------------------------------------------\n\n";
            moveAllReleventStatusesToProductString(mostLikedStatuses);
            m_Product.TextAnalysis += "\n-------------------------------------------------------------------------------------------------------------------------------------------\n";
        }

        public void BuildCommentsAnalyzer()
        {
            List<Status> mostCommentedStatuses = getListOfMostCommentedStatuses();
            m_Product.TextAnalysis += string.Format("Your Most Commented Statuses Has {0} Comments:\n", mostCommentedStatuses[0].Comments.Count);
            m_Product.TextAnalysis += "-------------------------------------------------------------------------------------------------------------------------------------------\n\n";
            moveAllReleventStatusesToProductString(mostCommentedStatuses);
            m_Product.TextAnalysis += "\n-------------------------------------------------------------------------------------------------------------------------------------------\n";
        }

        public void BuildBiggestFollowerAnalyzer()
        {
            m_Product.MostFollowerUser = findTheBiggestFollower();
            if (m_UserWhoLikedTheMost.Id != m_LoggedInUser.Id)
            {
                m_Product.TextAnalysis += string.Format("The User Who Liked You The Most Is: {0}\n", m_UserWhoLikedTheMost.Name);
            }
            else
            {
                m_Product.TextAnalysis += string.Format("The User Who Liked You The Most Is: Yourself\n");
            }

            m_Product.TextAnalysis += "-------------------------------------------------------------------------------------------------------------------------------------------";
        }

        public AnalysisProduct GetProduct()
        {
            return m_Product;
        }

        private void moveAllReleventStatusesToProductString(List<Status> i_StatusesWithHighestAmountOfLikes)
        {
            foreach (Status status in i_StatusesWithHighestAmountOfLikes)
            {
                m_Product.TextAnalysis += string.Format(
                    "{0} | {1} | Likes: {2} | Comments: {3} |\n",
                    status.CreatedTime.ToString(),
                    status.Message,
                    status.LikedBy.Count,
                    status.Comments.Count);
            }
        }

        public List<Status> getListOfMostLikedStatuses()
        {
            List<Status> allStatusesWithMostLikes = getAllStatusesByFilter(eStatusFilter.ByLikes);
            if (allStatusesWithMostLikes.Count == 0)
            {
                throw new Exception();
            }

            return allStatusesWithMostLikes;
        }

        private List<Status> getAllStatusesByFilter(eStatusFilter i_Filter)
        {
            if (m_AllStatuses == null)
            {
                m_AllStatuses = getAllStatuses();
            }

            List<Status> filteredStatuses = null;
            switch (i_Filter)
            {
                case eStatusFilter.ByLikes:
                    int highestNumberOfLikesInStatuses = getMaxNumberOfLikesInStatuses();
                    filteredStatuses = findAllStatusesWithHighestAmountOfLikes(highestNumberOfLikesInStatuses);
                    break;
                case eStatusFilter.ByComments:
                    int highestNumberOfCommentsInStatuses = getMaxNumberOfCommentsInStatuses();
                    filteredStatuses = findAllStatusesWithHighestAmountOfComments(highestNumberOfCommentsInStatuses);
                    break;
                default:
                    break;
            }

            return filteredStatuses;
        }

        private List<Status> getListOfMostCommentedStatuses()
        {
            List<Status> allStatusesWithMostComments = getAllStatusesByFilter(eStatusFilter.ByComments);
            if (allStatusesWithMostComments.Count == 0)
            {
                throw new Exception();
            }

            return allStatusesWithMostComments;
        }

        private User findTheBiggestFollower()
        {
            if (m_AllStatuses == null)
            {
                m_AllStatuses = getAllStatuses();
            }

            if (m_AllStatuses.Count == 0)
            {
                throw new Exception();
            }

            Dictionary<string, int> friendsIDsAndTheirLikesAmount = fillDictionaryWithFriendIDs();
            fillDictionaryWithLikesOfFriends(friendsIDsAndTheirLikesAmount);
            string idOfTheUserWhoLikedTheMost = getTheUserWhoLikedTheMost(friendsIDsAndTheirLikesAmount);
            m_UserWhoLikedTheMost = getFriendByID(idOfTheUserWhoLikedTheMost);
            return m_UserWhoLikedTheMost;
        }

        private Dictionary<string, int> fillDictionaryWithFriendIDs()
        {
            Dictionary<string, int> friendsIDsAndTheirLikesAmount = new Dictionary<string, int>();
            foreach (User friend in m_LoggedInUser.Friends)
            {
                friendsIDsAndTheirLikesAmount.Add(friend.Id, 0);
            }

            // add the current user in addition to its friends (user can like itself)
            friendsIDsAndTheirLikesAmount.Add(m_LoggedInUser.Id, 0);
            return friendsIDsAndTheirLikesAmount;
        }

        private void fillDictionaryWithLikesOfFriends(Dictionary<string, int> i_DictionaryToFillTheLikes)
        {
            foreach (Status status in m_AllStatuses)
            {
                if (status.LikedBy.Count > 0)
                {
                    foreach (User userThatLikesTheStatus in status.LikedBy)
                    {
                        i_DictionaryToFillTheLikes[userThatLikesTheStatus.Id] += 1;
                    }
                }
            }
        }

        private string getTheUserWhoLikedTheMost(Dictionary<string, int> i_DictionaryToSearchTheUser)
        {
            int highestAmountOfLikes = 0;
            string idOfTheUserWhoLikedTheMost = string.Empty;
            foreach (KeyValuePair<string, int> userIDAndHisLikes in i_DictionaryToSearchTheUser)
            {
                if (userIDAndHisLikes.Value > highestAmountOfLikes)
                {
                    highestAmountOfLikes = userIDAndHisLikes.Value;
                    idOfTheUserWhoLikedTheMost = userIDAndHisLikes.Key;
                }
            }

            if (highestAmountOfLikes == 0)
            {
                // if no one liked any status, we give a random friend id
                idOfTheUserWhoLikedTheMost = m_LoggedInUser.Friends[0].Id;
            }

            return idOfTheUserWhoLikedTheMost;
        }

        private User getFriendByID(string i_IDOfFriend)
        {
            User friendToLookFor = null;
            if (i_IDOfFriend == m_LoggedInUser.Id)
            {
                // sometimes the friend that liked the most is the user itself
                friendToLookFor = m_LoggedInUser;
            }
            else
            {
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    if (friend.Id == i_IDOfFriend)
                    {
                        friendToLookFor = friend;
                        break;
                    }
                }
            }

            return friendToLookFor;
        }

        private List<Status> findAllStatusesWithHighestAmountOfComments(int i_HighestAmountOfComments)
        {
            List<Status> allStatusesWithHighestAmountOfLikes = new List<Status>();
            foreach (Status status in m_AllStatuses)
            {
                if (status.Comments.Count == i_HighestAmountOfComments)
                {
                    allStatusesWithHighestAmountOfLikes.Add(status);
                }
            }

            return allStatusesWithHighestAmountOfLikes;
        }

        private int getMaxNumberOfCommentsInStatuses()
        {
            int highestNumberOfCommentsInStatuses = 0;
            foreach (Status status in m_AllStatuses)
            {
                if (status.Comments.Count > highestNumberOfCommentsInStatuses)
                {
                    highestNumberOfCommentsInStatuses = status.LikedBy.Count;
                }
            }

            return highestNumberOfCommentsInStatuses;
        }

        private List<Status> getAllStatuses()
        {
            List<Status> allStatuses = new List<Status>();
            foreach (Status status in m_LoggedInUser.Statuses)
            {
                if (string.IsNullOrEmpty(status.Message) == false)
                {
                    allStatuses.Add(status);
                }
            }

            return allStatuses;
        }

        private int getMaxNumberOfLikesInStatuses()
        {
            int highestNumberOfLikesInStatuses = 0;
            foreach (Status status in m_AllStatuses)
            {
                if (status.LikedBy.Count > highestNumberOfLikesInStatuses)
                {
                    highestNumberOfLikesInStatuses = status.LikedBy.Count;
                }
            }

            return highestNumberOfLikesInStatuses;
        }

        private List<Status> findAllStatusesWithHighestAmountOfLikes(int i_HighestAmountOfLikes)
        {
            List<Status> allStatusesWithHighestAmountOfLikes = new List<Status>();
            foreach (Status status in m_AllStatuses)
            {
                if (status.LikedBy.Count == i_HighestAmountOfLikes)
                {
                    allStatusesWithHighestAmountOfLikes.Add(status);
                }
            }

            return allStatusesWithHighestAmountOfLikes;
        }
    }
}
