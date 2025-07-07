using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.DTOLayer.Dtos.RoomDto
{
    public class CreateRoomDto
    {
        [Required(ErrorMessage ="Lütfen Oda Numarasını Giriniz")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Fiyatını Giriniz")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Türünü Giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen Yatak Sayısını Giriniz")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen Banyo Sayısını Giriniz")]
        public string BathCount { get; set; }
        [Required(ErrorMessage = "Lütfen Wifi Sayısını Giriniz")]
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Açıklamasını Giriniz")]
        public string Description { get; set; }
    }
}
