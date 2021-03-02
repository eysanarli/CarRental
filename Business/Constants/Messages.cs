using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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

        public static string ColorAdded = "Renk başarıyla eklendi";
        public static string ColorDeleted = "Renk başarıyla silindi";
        public static string ColorUpdated = "Renk başarıyla güncellendi";
        public static string ColorList = "Renkler listesi";

        public static string UserEmailExist = "Aynı email adresinden mevcut, lütfen farklı bir email adresiyle deneyiniz";
        public static string UserAdded = "Kullanıcı başarıyla eklendi";
        public static string UserDeleted = "Kullanıcı başarıyla silindi";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi";
        public static string UserGetById = "Kullanıcı detay getirildi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz";

        public static string CustomerCompanyExist = "Aynı şirket isminden mevcut,ekleme başarısız.";
        public static string CustomerAdded = "Müşteri başarıyla eklendi";
        public static string CustomerDeleted = "Müşteri başarıyla silindi";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi";
        public static string CustomerGetById = "Müşteri detay getirildi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomerNameInvalid = "Müşteri ismi geçersiz";

        public static string RentalAdded = "Araba başarıyla kiralandı";
        public static string RentalDeleted = "Araba başarıyla kiralama listesinden silindi";
        public static string RentalUpdated = "Araba kiralama listesi başarıyla güncellendi";
        public static string RentalGetById = "Araba kiralama detay getirildi";
        public static string RentalInvalid = "Araba henüz teslim edilmemiş";

        public static string NumberOfPictureError = "Arabaya ait resimler en fazla 5 tane olabilir";
        public static string InvalidFileType = "Dosya tipi geçersiz";

       
        public static string UserRegistered="Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string BrandNameAlreadyExists = "Marka ismi zaten mevcut";
    }
}
