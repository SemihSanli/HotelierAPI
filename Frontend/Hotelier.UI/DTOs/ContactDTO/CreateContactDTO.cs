﻿using Hotelier.EntityLayer;

namespace Hotelier.UI.DTOs.ContactDTO
{
    public class CreateContactDTO
    {

        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int MessageCategoryID { get; set; }
        public MessageCategory MessageCategory { get; set; }
    }
}
