using FriendOrganizer.Models;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataServices : IFriendDataServices
    {
        public IEnumerable<Friend> GetAll()
        {
            //TODO: Luego se cambiara para traer datos reales.

            yield return new Friend() { FirstName = "Jesus", LastName = "Dicent" };
            yield return new Friend() { FirstName = "Carlos", LastName = "Rodriguez" };
            yield return new Friend() { FirstName = "Lucero", LastName = "Albares" };
            yield return new Friend() { FirstName = "Pedro", LastName = "Almonte" };

        }
    }
}
