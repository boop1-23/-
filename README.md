# Hospital Management System

نظام إدارة مستشفى داخلي باستخدام ASP.NET Core 10 وBlazor Server وPostgreSQL.

## تشغيل سريع محلي

المتطلبات: Docker Desktop و.NET 10 SDK.

```bash
docker compose up -d postgres
export ConnectionStrings__DefaultConnection='Host=localhost;Database=hospital;Username=hospital_app;Password=change-this-local-password'
export SeedAdmin__Email='admin@hospital.local'
export SeedAdmin__Password='Change-Me-Strong!123'
dotnet run
```

على PowerShell استخدم:

```powershell
docker compose up -d postgres
$env:ConnectionStrings__DefaultConnection='Host=localhost;Database=hospital;Username=hospital_app;Password=change-this-local-password'
$env:SeedAdmin__Email='admin@hospital.local'
$env:SeedAdmin__Password='Change-Me-Strong!123'
dotnet run
```

افتح عنوان HTTP الذي يظهره .NET. غيّر كلمات المرور قبل أي تشغيل فعلي.

## الإتاحة الداخلية

شغّل فقط على شبكة المستشفى الموثوقة، واستخدم reverse proxy أو Kestrel مع شهادات HTTPS داخلية. النسخة الحالية لا تغطي جاهزية امتثال كامل ولا تعويضًا إلكترونيًا أو سير عمل سريري آمنًا.

## البيانات الحية

لا تستخدم السجلات أو أسماء المرضى الحقيقية حتى يكتمل تشفير التخزين، النسخ الاحتياطي، التفويض حسب القسم، وسجل التدقيق الكامل.
