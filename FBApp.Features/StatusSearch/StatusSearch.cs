using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FBApp.Features
{
    internal class StatusSearch : IStatusSearch
    {
        public List<Tuple<User, Status>> GetAllStatuses(string i_StringToSearch, List<User> i_Friends)
        {
            List<Tuple<User, Status>> relevantStatuses = new List<Tuple<User, Status>>();
            foreach (User friend in i_Friends)
            {
                foreach (Status friendStatus in friend.Statuses)
                {
                    if (friendStatus.Message != null)
                    {
                        if (friendStatus.Message.Contains(i_StringToSearch))
                        {
                            relevantStatuses.Add(new Tuple<User, Status>(friend, friendStatus));
                        }
                    }
                }
            }

            return relevantStatuses;
        }
    }
}