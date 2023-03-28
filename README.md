# Rent-a-car-project
M13 - Project:

Razdelenie - Class Library създаваме:
1-Modles
2-ViewModels
3-Data-Migrations,DbContext
4-Services-Interfeices
5-NameofProekt.Common- static GlobalConstants (роли, константи)
Razdelenie - WebApp:
1-Web-controlers

Stupka 1
- създаваме си всички Class Library и Web app с индивидуални контролери

Stupka 2
- правите референции: Models(NameofProekt.Common) Data(Models,NameofProekt.Common), Services(Data,Models,ViewModels,NameofProekt.Common),ViewModels(Models,NameofProekt.Common),Web(Всичко)

Stupka 3
- създаваме и попълваме моделите

Stupka 4
- попълване на AppDbContext 
- пускаме миграции и оправяме грешките

Stupka 5
- конектион стринг правиш за всеки един от екипа
