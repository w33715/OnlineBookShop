using Hospital.ViewModels;

using Hospitals.Utilities;

namespace Hospital.Services
{
    public interface IRoomService
    {
        PagedResult<RoomViewModel> GetAll(int pageNumber, int pageSize);
        RoomViewModel GetRoomById(int RoomId);
        void UpdateRoom(RoomViewModel Room);
        void InsertRoom(RoomViewModel Room);
        void DeleteRoom(int id);
    }
}
