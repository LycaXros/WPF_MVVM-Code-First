using System;
namespace FriendOrganizer.UI.Data
{
    public interface IFriendDataServices
    {
        System.Collections.Generic.IEnumerable<FriendOrganizer.Models.Friend> GetAll();
    }
}
