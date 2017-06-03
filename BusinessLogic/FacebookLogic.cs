using FacebookApp.BusinessLogic.Builder;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace FacebookApp.BusinessLogic
{
    public class FacebookLogic
    {
        public event LoginFinishedEvent LoginFinished;
        public delegate void LoginFinishedEvent();
        public event LogoutFinishedEvent LogoutFinished;
        public delegate void LogoutFinishedEvent();
        public User LoggedInUser { get; private set; }
        static private FacebookLogic instance;
        public User CommonLikesFriend { get; private set; }
        public User CommonFriendsFriend { get; private set; }

        private FacebookLogic()
        {

        }

        static public FacebookLogic GetInstance()
        {
            if (instance == null)
            {
                instance = new FacebookLogic();
            }

            return instance;
        }
 
        public void Login()
        {
            LoginResult result = FacebookService.Login(
              "1470264299671719",
              "public_profile",
              "user_birthday",
              "user_friends",
              "user_likes",
              "user_location",
              "user_photos",
              "user_posts");

            if (result != null)
            {
                LoggedInUser = result.LoggedInUser;
                getCommonFriends();
                LoginFinished();
            }
        }

        public void Logout()
        {
            LoggedInUser = null;
            FacebookService.Logout(LogoutFinishedHandler);
        }

        private void LogoutFinishedHandler()
        {
            LogoutFinished();
        }

        internal Chart GetChart(eChartType type, Chart chart)
        {
            return ChartBuilderDirector.BuildChartData(type, LoggedInUser, chart);
        }

        private void getCommonFriends()
        {
            int maxPages = 0;
            int maxFriends = 0;

            // Set as self, in case no one has anything in common with user.
            CommonLikesFriend = LoggedInUser;
            CommonFriendsFriend = LoggedInUser;

            // Get friend with max common friends and max common likes
            foreach (User friend in LoggedInUser.Friends)
            {
                int commonLikes = getCommonLikes(friend);
                int commonFriends = GetCommonFriends(friend);

                if (commonLikes > maxPages)
                {
                    maxPages = commonLikes;
                    CommonLikesFriend = friend;
                }

                if (commonFriends > maxFriends)
                {
                    maxFriends = commonFriends;
                    CommonFriendsFriend = friend;
                }
            }
        }

        private int GetCommonFriends(User friend)
        {
            int count = 0;

            foreach (User userFriend in LoggedInUser.Friends)
            {
                foreach (User friendFriend in friend.Friends)
                {
                    if (userFriend.Id == friendFriend.Id)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private int getCommonLikes(User friend)
        {
            int count = 0;

            foreach (Page likedPage in LoggedInUser.LikedPages)
            {
                foreach (Page friendLikedPage in friend.LikedPages)
                {
                    if (likedPage.Id == friendLikedPage.Id)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}