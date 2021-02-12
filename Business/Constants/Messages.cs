using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string BrandIdExist = "Aynı Brand Id'den araç bulundu";
        public static string CarAdded = "Araba başarıyla eklendi.";
        public static string CarDescriptionInvalid = "";
        public static string CarNameInvalid = "Araba ekleme işleminiz başarısız oldu. --> Araba isminiz minimum 2 karakter olmak üzere giriniz";
        public static string CarDailyPriceInvalid = "Araba ekleme işleminiz başarısız oldu. --> Günlük fiyat kısmını 0'dan büyük olmak üzere giriniz. Girdiğiniz değer : {car.DailyPrice}";
        public static string CarDeleted = "Araba başarıyla silindi.";
        public static string CarUpdated = "Araba başarıyla güncellendi";
        public static string CarUpdatedInvalid = "Lütfen günlük fiyat kısmını 0'dan büyük giriniz. Girdiğiniz değer";
        public static string CarList = "Arabalar listesi";
        public static string MaintenanceTime = "Sistem bakımda";

        public static string BrandAdded = "Marka başarıyla eklendi.";
        public static string BrandNameInvalid = "Lütfen marka isminin uzunluğunu 2 karakterden fazla olmak üzere giriniz. Girdiğiniz marka ismi : {brand.BrandName}";
        public static string BrandDeleted = "Marka başarıyla silindi.";
        public static string BrandUpdated = "Marka başarıyla Güncellendi.";
        public static string BrandUpdatedInvalid = "Lütfen marka isminin uzunluğunu 1 karakterden fazla olmak üzere giriniz.";
        public static string BrandList = "Markalar listesi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorList = "Renkler listesi";

       
    }
}
