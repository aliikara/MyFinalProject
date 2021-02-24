using System;
using System.Collections.Generic;
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
    }
}
