﻿using Hospital.ViewModels;

using Hospitals.Utilities;

namespace Hospital.Services
{
    public interface IContactService
    {
        PagedResult<ContactViewModel> GetAll(int pageNumber, int pageSize);
        ContactViewModel GetContactById(int ContactId);
        void UpdateContact(ContactViewModel contact);
        void InsertContact(ContactViewModel contact);
        void DeleteContact(int id);
    }
}
