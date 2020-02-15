namespace CorporateHotel.Domain
{
    public class Hotel
    {
        public HotelId Id { get; }
        public RoomType RoomType { get; }
        public int Rooms { get; }

        public Hotel()
        {
            Id = new HotelId();
        }
    }
}
