using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public const string BrandAdded = "Marka eklendi";
        public const string BrandDeleted = "Marka silindi";
        public const string BrandUpdated = "Marka güncellendi";
        public const string BrandListed = "Markalar listelendi";
        public const string BrandGet = "Marka getirildi";

        public const string CarAdded = "Araç eklendi";
        public const string CarDeleted = "Araç silindi";
        public const string CarUpdated = "Araç güncellendi";
        public const string CarListed = "Araçlar listelendi";
        public const string CarDetailListed = "Araç detayları listelendi";
        public const string CarGet = "Araç getirildi";
        public const string CarNameInvalid = "Araç ismi en az 2 karakter olmalı";
        public const string CarPriceInvalid = "Araç fiyatı 1 den büyük olmalıdır";

        public const string ColorAdded = "Renk eklendi";
        public const string ColorDeleted = "Renk silindi";
        public const string ColorUpdated = "Renk güncellendi";
        public const string ColorListed = "Renkler listelendi";
        public const string ColorGet = "Renk getirildi";

        public const string UserAdded = "Kullanıcı eklendi";
        public const string UserDeleted = "Kullanıcı silindi";
        public const string UserUpdated = "Kullanıcı güncellendi";
        public const string UserListed = "Kullanıcılar listelendi";
        public const string UserGet = "Kullanıcı getirildi";

        public const string CustomerAdded = "Müşteri eklendi";
        public const string CustomerDeleted = "Müşteri silindi";
        public const string CustomerUpdated = "Müşteri güncellendi";
        public const string CustomerListed = "Müşteriler listelendi";
        public const string CustomerGet = "Müşteri getirildi";

        public const string RentalAdded = "Kiralama yapıldı";
        public const string RentalDeleted = "Kiralama silindi";
        public const string RentalUpdated = "Kiralama güncellendi";
        public const string RentalListed = "Kiralamalar listelendi";
        public const string RentalGet = "Kiralama getirildi";
        public const string RentalErrorBecauseNotReturned = "Bu araç iade edilmediği için kiralama yapılamaz.";
    }
}
