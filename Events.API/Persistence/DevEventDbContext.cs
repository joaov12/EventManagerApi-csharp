using Events.API.Entities;

namespace Events.API.Persistence
{
    public class DevEventDbContext
    {
        public List<DevEvent> DevEvents{ get; set; }

        public DevEventDbContext()
        {
            DevEvents = new List<DevEvent>();
        }
    }
}
