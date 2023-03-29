# Rent-a-car-project
M13 - Project:

Razdelenie - Class Library създаваме:

1-Modeles

2-ViewModels

3-Data-Migrations,DbContext

4-Services-Interfeices

5-NameofProekt.Common- static GlobalConstants (роли, константи), RolesSeeder:ISeeder там сийдваме данните

Razdelenie - WebApp:

1-Web-controlers

 Стъпка 1
- създаваме си всички Class Library и Web app с индивидуални контролери

Стъпка 2
- правите референции: Models(NameofProekt.Common) Data(Models,NameofProekt.Common), Services(Data,Models,ViewModels,NameofProekt.Common),ViewModels(Models,NameofProekt.Common),Web(Всичко)

Стъшка 3
- създаваме и попълваме моделите

Стъпка 4
- попълване на AppDbContext и настройване да работи с User и RoleManager!
- инстанцираме Seeders
- конектион стринг правиш за всеки един от екипа.
- пускаме миграции и оправяме грешките

Стъпка 5
- настройваш Start.up и в LoginPartial ,и ViewImprots

Стъпка 6
-> Areas -> Identity -> Scaffold -> Login/Register
Стъпка 7
-> Поправя се View-то на Register
*await user manager.AddToRole
Стъпка 8
- Странициране- във ViewModels-> Shared -> PagingViewModel
- във Web->Veiws->Shared->PagingPartil и в Imports добавяме using за ViewModels
Стъпка 9
- във Services поставяме IUserService
- във ViewModels правим папка за Users и в нея правим ViewModel за Create
- създаваме UserService и почваме да попълваме според IUserService и ViewModel за Create
Ступка 10
- създаваме UsersControler и го попълваме
- оправяме Views
