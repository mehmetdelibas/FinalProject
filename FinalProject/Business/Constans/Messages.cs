using Core.Entities.Concrete;

namespace Business.Constans
{
    public static class Messages
    {
        //Sistem hata mesajlari
        public static string MaintenanceTime = "Sistem Bakımda";


        //Product hata mesajlari
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir Kategoride Max 10 Urun Olabilir";
        public static string ProductNameAlreadyExist = "Zaten bu isimde bir urun var";

        //Employee hata mesajlari
        public static string EmployeeAdded = "Çalışan Eklendi";
        public static string EmployeeNameInvalid = "Çalışan İsmi Geçersiz";
        public static string EmployeeListed = "Çalışanlar Listelendi";
        //Category hata mesajlarıi
        public static string CategoryAdded = "Kategori Eklendi";
        public static string CategoryNameInvalid = "Kategori İsmi Geçersiz";
        public static string CategoryListed = "Kategoriler Listelendi";
        public static string CategoryLimitExceded = "Kategori Limiti Asıldıgı Icın Yeni Urun Ekelnemiyor";
        //Order hata mesajlari
        public static string OrderAdded = "Sipariş Eklendi";
        public static string OrderNameInvalid = "Sipariş İsmi Geçersiz";
        public static string OrderListed = "Siparişler Listelendi";
        //yetki kontrolu
        public static string AuthorizationDenied = "Yetkiniz Yok";
        public static string UserRegistered = "Kullanici olusturuldu";
        public static string UserNotFound = "Kullanici bulunamadi";
        public static string PasswordError = "Şifre hatali";
        public static string SuccessfulLogin = "Giris basarili";
        public static string UserAlreadyExists = "Kullanici mevcut";
        public static string AccessTokenCreated = "Giris tokeni olusturuldu";
    }
}
