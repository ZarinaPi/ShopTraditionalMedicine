   M S B A M L   `   `   `  ????E  Acoursework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:coursework
coursework  5   	       coursework.AdminPanel   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:coursework     5   	     ? Title$  
AdminPanel??5   	   $	??450??6   $	??800??6)   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??* ?6   6)   ?? 5      $??50 ?6   6*   .+?5   
   ??  ?? TabStripPlacement$
 Left=?6   .@?5      ?? $)??#Список сотрудников??6   .??5      ?  5      ?? 5      $??* ?6(   65   ?? 5      $	??100 ?6(   67   .+?5      &   System.Windows.Controls.DataGrid  -   5          Name$ UserDG??5         AutoGenerateColumns$ False??5         
IsReadOnly$
 True??5         SelectionMode$ Single=?5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID??61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   ?? *IdUser+  5      $ Фамилия??61   	 6B   ?? *SurnameUser+  5      $ Имя??61   	 6>   ?? *
NameUser+  5      $ Отчество??61   	 6C   ?? *PatronymicUser+  5      $ Моб. номер??61   	 6E   ?? *MobileNumberUser+  5      $ Адресс??61   	 6A   ?? *AddressUser+  5       $ Отчество??61   	 6C   ?? *Login+  5!      $ Моб. номер??61   	 6E   ?? *
Password+  5"      $ Адресс??61   	 6A   ?? *Role+5$      ?? 5%      $??1??6!   
 ?? Orientation$
 
Horizontal=?6.   .+?5&      ?? -   5         ??Name$ AddUser??5+      $??Добавить??5&   !   $??5q?5'      $
??auto??5(      $
??Left=?5)      $??Center=?5*      5-      ?? 5.      -   5        $ 
DeleteUser??53      $??Удалить??5.   !   $??5q?5/      $
??auto??50      $
??Left=?51      $??Center=?52      55      ?? 56      -   5        $ 
UpdateUser??5;      $5??/Редактировать информацию??56   !   $??5q?57      $
??auto??58      $
??Left=?59      $??Center=?5:      5=      5>      5?      5@      ?? 5A      $??Отчёты??6   .??5B      ?? $N??HНа данный момент страница в разработке!??6   $??Center=?5C      $??Center=?5D      $??25(?5E      $
??Bold"?6&   5F      5G      5H      ?? 5I   
   -   5        $
 Exit??5O      $??1??5I      $??Bottom=?5J      $??Right=?5K      $??
Выйти??5L      $
??auto??5M      $??5q?5N       ? Cursor$
 Hand??5P   $   5Q      5R      5S      