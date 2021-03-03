using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz.";
        public static string MaintenanceTime = "Sistem Bakımda.";
        public static string ProductsListed = "Ürünler Listelendi.";
        public static string UnitPriceInvalid = "Ürün Fiyatı Sıfırdan Küçük.";
        public static string ProductCountError = "Bir Kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu Ürün Adında Ürün Bulunmaktadır.";
        public static string CategoryLimitExceded = "Kategori Limiti Aşıldığı için Yeni Ürün Eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string ProductUpdated = "Ürün Başarıyla Güncellendi";
    }
}
