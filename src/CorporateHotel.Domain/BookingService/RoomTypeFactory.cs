namespace CorporateHotel.Domain
{
    public static class RoomTypeFactory
    {
        public static RoomType StandardSingle => new RoomType();
        public static RoomType StandardDouble => new RoomType();
        public static RoomType Junior => new RoomType();
        public static RoomType Master => new RoomType();
    }
}
