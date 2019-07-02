using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FBApp.Features
{
    internal interface IStatusSearch
    {
        List<Tuple<User, Status>> GetAllStatuses(string i_StringToSearch, List<User> i_Friends);
    }
}
