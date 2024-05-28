using Hospital.Services;
using Hospital.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace Hospital.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class RoomsController : Controller
    {

        private IRoomService _roomService;
        private IHospitalInfo _hospitalInfo;
        public RoomsController(IRoomService roomService, IHospitalInfo hospitalInfo)
        {
            _roomService = roomService;
            _hospitalInfo = hospitalInfo;
        }
        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {
            return View(_roomService.GetAll(pageNumber, pageSize));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {

            // ViewBag.hospital = new SelectList(_hospitalInfo.GetAll(), "Id", "Name");
            var viewModel = _roomService.GetRoomById(id);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(RoomViewModel vm)
        {
            _roomService.UpdateRoom(vm);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(RoomViewModel vm)
        {
            _roomService.InsertRoom(vm);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _roomService.DeleteRoom(id);
            return RedirectToAction("Index");
        }
    }
}
