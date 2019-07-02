using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections.Generic;

namespace FBApp.Features
{
    public class EventService
    {
        private User m_LoggedInUser;
        private ComboBox m_ComboBoxOfFriends;
        public Event FriendWithMostLikedEvent { get; set; }

        public EventService(User i_User, ComboBox i_ListOfFriends)
        {
            m_LoggedInUser = i_User;
            m_ComboBoxOfFriends = i_ListOfFriends;
        }

        public void LoadComboBoxFriendsToFindMostPopularEvent()
        {
            m_ComboBoxOfFriends.DisplayMember = "Name";
            foreach (User friend in m_LoggedInUser.Friends)
            {
                m_ComboBoxOfFriends.Items.Add(friend);
            }

           // m_ComboBoxOfFriends.SelectedIndex = 0;
        }

        public void FriendEventService(RichTextBox i_RichTextBoxMostPopularEventDetails, PictureBox i_PictureBoxOfEvent, Button i_ButtonEventShare, Button i_ButtonAttendingToEvent)
        {
            int highestNumOfAttendingPeopleInEvent;
            User selectedFriend = findSelectedFriend(m_ComboBoxOfFriends.SelectedItem);
            FriendWithMostLikedEvent = null;
            FriendWithMostLikedEvent = findMostPopularEvent(m_LoggedInUser, selectedFriend, out highestNumOfAttendingPeopleInEvent); //?
            fetchEventDetails(i_RichTextBoxMostPopularEventDetails, i_PictureBoxOfEvent, i_ButtonEventShare, i_ButtonAttendingToEvent);
        }
        private User findSelectedFriend(object i_SelectedItem)
        {
            User selectedFriend = null;

            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (friend.Name.Equals(i_SelectedItem))
                {
                    selectedFriend = friend;
                }
            }

            return selectedFriend;
        }

        private Event findMostPopularEvent(User i_LoggedInUser, User i_SelectedUser, out int i_HighestNumOfAttendingPeopleInEvent)
        {
            FacebookService.s_CollectionLimit = 30;
            FacebookObjectCollection<Event> allUserEvents = i_SelectedUser.Events;
            Dictionary<string, int> numberOfPeopleAttendingToEventsOfUser = findNumberOfAttendingToEventsPerUser(allUserEvents);
            string mostPopularEvent = findMostPopularEventOfUser(numberOfPeopleAttendingToEventsOfUser, out i_HighestNumOfAttendingPeopleInEvent);

            return findFriendMostPopularEventDetails(allUserEvents, mostPopularEvent);
        }

        private Dictionary<string, int> findNumberOfAttendingToEventsPerUser(FacebookObjectCollection<Event> i_AllUserEvents)
        {
            Dictionary<string, int> numberOfAttendingToEventPerUser = new Dictionary<string, int>();
            FacebookService.s_CollectionLimit = 400;

            foreach (Event eventOfUser in i_AllUserEvents)
            {
                numberOfAttendingToEventPerUser.Add(eventOfUser.Id, 0);
                numberOfAttendingToEventPerUser[eventOfUser.Id] += eventOfUser.AttendingUsers.Count;
            }

            return numberOfAttendingToEventPerUser;
        }

        private string findMostPopularEventOfUser(Dictionary<string, int> i_NumberOfPeopleAttendingToEventsOfUser, out int i_HighestNumOfAttendingPeopleInEvent)
        {
            string mostPopularEvent = null;
            int mostAttendingPeopleInEvent = 0;

            foreach (KeyValuePair<string, int> eventAttending in i_NumberOfPeopleAttendingToEventsOfUser)
            {
                if (mostAttendingPeopleInEvent < eventAttending.Value)
                {
                    mostPopularEvent = eventAttending.Key;
                    mostAttendingPeopleInEvent = eventAttending.Value;
                }
            }

            i_HighestNumOfAttendingPeopleInEvent = mostAttendingPeopleInEvent;

            return mostPopularEvent;
        }

        private Event findFriendMostPopularEventDetails(FacebookObjectCollection<Event> i_AllUserEvents, string i_MostPopularEvent)
        {
            Event mostPopularEvent = null;

            foreach (Event userEvent in i_AllUserEvents)
            {
                if (userEvent.Id == i_MostPopularEvent)
                {
                    mostPopularEvent = userEvent;
                }
            }

            return mostPopularEvent;
        }

        private void fetchEventDetails(RichTextBox i_RichTextBoxMostPopularEventDetails, PictureBox i_PictureBoxOfEvent, Button i_ButtonEventShare, Button i_ButtonAttendingToEvent)
        {
            if (FriendWithMostLikedEvent != null)
            {
                showEventDetails(FriendWithMostLikedEvent, i_RichTextBoxMostPopularEventDetails);
                i_PictureBoxOfEvent.LoadAsync(FriendWithMostLikedEvent.PictureNormalURL);
                i_ButtonEventShare.Enabled = true;
                if (FriendWithMostLikedEvent.EndTime != null && FriendWithMostLikedEvent.EndTime.Value > DateTime.Today)
                {
                    i_ButtonAttendingToEvent.Enabled = true;
                }
            }
            else
            {
                i_RichTextBoxMostPopularEventDetails.Text += "There are no available events to show";
            }
        }

        private void showEventDetails(Event i_Event, RichTextBox i_RichTextBoxMostPopularEventDetails)
        {
            if (i_Event.Owner != null)
            {
                i_RichTextBoxMostPopularEventDetails.Text += string.Format("Owner: {0}\n", i_Event.Owner.Name);
            }

            if (i_Event.StartTime != null)
            {
                i_RichTextBoxMostPopularEventDetails.Text += string.Format("Start Time: {0}\n", i_Event.StartTime);
            }


            if (i_Event.EndTime != null)
            {
                i_RichTextBoxMostPopularEventDetails.Text += string.Format("End Time: {0}\n", i_Event.EndTime);
            }

            if (i_Event.Location != null)
            {
                i_RichTextBoxMostPopularEventDetails.Text += string.Format("Location: {0}\n", i_Event.Location);
            }

            if (i_Event.Place != null)
            {
                i_RichTextBoxMostPopularEventDetails.Text += string.Format("Place: {0}\n", i_Event.Place.Name);
            }

            if (i_Event.LinkToFacebook != null)
            {
                i_RichTextBoxMostPopularEventDetails.Text += string.Format("Link to facebook: {0}\n", i_Event.LinkToFacebook);
            }
        }
    }
}
