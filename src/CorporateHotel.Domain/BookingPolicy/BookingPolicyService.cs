namespace CorporateHotel.Domain
{
    public class BookingPolicyService
    {
        public void SetCompanyPolicy(CompanyId companyId, params RoomType[] roomTypes)
        {

        }

        public void SetEmployeePolicy(EmployeeId employeeId, params RoomType[] roomTypes)
        {

        }

        public bool IsBookingAllowed(EmployeeId employeeId, RoomType roomType)
        {
            return false;
        }

    }
}
