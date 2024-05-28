using Hospital.Models;

namespace Hospital.ViewModels
{
    public class ContactViewModel
    {
        public int Id { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
        public int HospitalInfoId { get; set; }

        public ContactViewModel()
        {

        }
        public ContactViewModel(Contact model)
        {
            Id = model.Id;
            EMail = model.Email;
            Phone = model.Phone;
            HospitalInfoId = model.HospitalId;
        }

        public Contact ConvertViewModel(ContactViewModel model)
        {
            return new Contact
            {
                Id = model.Id,
                Email = model.EMail,
                Phone = model.Phone,
                HospitalId = model.HospitalInfoId,

            };
        }
    }
}
