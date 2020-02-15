using CorporateHotel.Domain;
using System;
using Xunit;
using FluentAssertions;

namespace CorporateHotel.Tests
{
    public class HotelServiceShould
    {
        private readonly HotelService service;

        private readonly Hotel carltonHotel;
        private readonly RoomType doubleRoomType;
        private readonly RoomType singleRoomType;

        public HotelServiceShould()
        {
            service = new HotelService();
            carltonHotel = new Hotel();
            doubleRoomType = RoomTypeFactory.StandardDouble;
            singleRoomType = RoomTypeFactory.StandardDouble;
        }

        [Fact]
        public void Create_new_hotel_when_id_hotel_does_not_exist()
        {
            var granHotelDomine = new Hotel();
            service.SetRoomType(granHotelDomine.Id, doubleRoomType, 3);

            var searched = service.FindHotelBy(granHotelDomine.Id);

            searched.Should().BeEquivalentTo(granHotelDomine);
        }

        [Fact]
        public void Update_existing_hotel_when_id_hotel_already_exist()
        {
            var ercillaHotel = new Hotel();
            service.SetRoomType(ercillaHotel.Id, doubleRoomType, 3);
            service.SetRoomType(ercillaHotel.Id, singleRoomType, 7);

            var searched = service.FindHotelBy(ercillaHotel.Id);

            searched.Id.Should().Be(ercillaHotel.Id);
            searched.Rooms.Should().Be(7);
            searched.RoomType.Should().BeEquivalentTo(doubleRoomType);
        }
    }

    public class CompanyServiceShould
    {
        private readonly CompanyService service;

        private readonly Hotel carltonHotel;
        private readonly RoomType doubleRoomType;
        private readonly RoomType singleRoomType;

        public CompanyServiceShould()
        {
            service = new CompanyService();
            carltonHotel = new compa();
            doubleRoomType = RoomTypeFactory.StandardDouble;
            singleRoomType = RoomTypeFactory.StandardDouble;
        }

        [Fact]
        public void Create_new_hotel_when_id_hotel_does_not_exist()
        {
            var granHotelDomine = new Hotel();
            service.SetRoomType(granHotelDomine.Id, doubleRoomType, 3);

            var searched = service.FindHotelBy(granHotelDomine.Id);

            searched.Should().BeEquivalentTo(granHotelDomine);
        }

        [Fact]
        public void Update_existing_hotel_when_id_hotel_already_exist()
        {
            var ercillaHotel = new Hotel();
            service.SetRoomType(ercillaHotel.Id, doubleRoomType, 3);
            service.SetRoomType(ercillaHotel.Id, singleRoomType, 7);

            var searched = service.FindHotelBy(ercillaHotel.Id);

            searched.Id.Should().Be(ercillaHotel.Id);
            searched.Rooms.Should().Be(7);
            searched.RoomType.Should().BeEquivalentTo(doubleRoomType);
        }
    }
}
