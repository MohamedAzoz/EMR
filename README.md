# EMR
🧪 Running Tests with Code Coverage (EMR Project)

⚠️ تنبيه مهم:
أسماء الـ Folders (مثل Backend Code أو EMR) وأسماء ملفات الـ Solution وملفات داخل TestResults مش ثابتة،
ولازم تغيرها حسب اسم مشروعك ومسارات الملفات عندك.

1️⃣ الدخول إلى مجلد المشروع
cd ".\Backend Code"
cd ".\EMR"

2️⃣ تشغيل Coverlet لعرض نسبة التغطية
coverlet ".\EMR.Test\bin\Debug\net8.0\EMR.Test.dll" `
    -t "dotnet" `
    -a "test --no-build" `
    --exclude-by-file ".\اسم_الملف_الذي_تريد_استثناؤه.cs"


📌 هذا الأمر يعرض لك نسبة التغطية (Code Coverage) للـ Unit Tests.

يمكنك استثناء ملفات معينة من الحساب بإضافتها في --exclude-by-file.

3️⃣ الحصول على تقرير بتنسيق XML
dotnet test --collect:"XPlat Code Coverage"


📌 هذا الأمر يولد ملف XML يحتوي تفاصيل التغطية داخل فولدر TestResults.

4️⃣ تثبيت أداة ReportGenerator (مرة واحدة فقط)
dotnet tool install -g dotnet-reportgenerator-globaltool

5️⃣ توليد تقرير HTML

انتقل أولاً إلى مجلد التست:

cd ".\EMR.Test"


ثم شغل الأمر:

reportgenerator `
  -reports:".\TestResults\ae3b3549-538c-474a-b364-da8a8bdd924d\coverage.cobertura.xml" `
  -targetdir:"CodeTesting" `
  -reporttypes:HTML


📌 لاحظ:

اسم الفولدر داخل TestResults (ae3b3549-...) بيختلف كل مرة بتشغل فيها الـ Tests.

فولدر CodeTesting هيتولد تلقائيًا وهيحتوي على تقرير HTML.

6️⃣ فتح التقرير

بعد الخطوات السابقة، هتلاقي ملف:

CodeTesting\index.html


تقدر تفتحه من المتصفح وتشوف تقرير التغطية بشكل مرئي ومنسق.
