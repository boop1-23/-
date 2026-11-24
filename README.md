# Hospital Management System

نظام إدارة مستشفى داخلي مبني بـ ASP.NET Core 10 وBlazor Server وPostgreSQL.

## البداية

1. ثبّت .NET 10 SDK وPostgreSQL.
2. عيّن إعدادات قاعدة البيانات ومستخدم المدير في متغيرات البيئة:

```bash
ConnectionStrings__DefaultConnection="Host=localhost;Database=hospital;Username=hospital_app;Password=change-me"
SeedAdmin__Email="admin@hospital.local"
SeedAdmin__Password="Strong-Password-Here!123"
ASPNETCORE_URLS="http://0.0.0.0:8080"
```

3. شغّل:

```bash
dotnet run
```

4. افتح الرابط المحلي المعروض، وسجّل الدخول بحساب المدير الذي عيّنته.

> لا تستخدم بيانات مرضى حقيقية أثناء التطوير. هذا المشروع يحتاج مراجعة امتثال وحماية بيانات قبل التشغيل الإنتاجي.

## النطاق الأول

- الأقسام الديناميكية وإدارة حالتها
- المستخدمون والأدوار
- صلاحية المدير لإضافة الأقسام والموظفين
- العقود والأجور (المرحلة التالية)
- تصميم عربي RTL وتجهيز لواجهة محلية آمنة

## الأمان

- استخدم HTTPS أو بوابة عكسية مشفرة داخل الشبكة
- لا تضع كلمات المرور في المستودع
- فعّل النسخ الاحتياطي المشفر لقاعدة PostgreSQL
- راجع الصلاحيات والسجلات بانتظام
