   M S B A M L   `   `   `  ????E  Acoursework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:coursework
coursework  5   	       coursework.SellerPanel   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:coursework     5   	   -   5          ? Title$  SellerPanel??5   	   $	??450??6   $
??1000??6*   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??* ?6   6)   ?? 5      $??50 ?6   6*   .+?5   
   ??  ?? TabStripPlacement$
 Left=?6   .@?5      ?? $??Товары??6   .??5      ?  5      ?? 5      $??* ?6(   65   ?? 5      $	??100 ?6(   67   .+?5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	ProductDG??5         AutoGenerateColumns$ False??5         
IsReadOnly$
 True??5         SelectionMode$ Single=?5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID??61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   ?? *	IdProduct+  5      $ Наименования??61   	 6G   ?? *NameProduct+  5      $, &Количество на складе??61   	 6O   ?? *QuantityProduct+  5      $ Ед. измерения??61   	 6H   ?? *NameUnitProduct+  5      $&  Цена за ед. товара??61   	 6M   ?? *PriceProduct+4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate
 5    "   ?? 5!   &   .R?5"   *   ??  ??Name$ btnUpdateProduct??61   -   5        $ ??Редактировать??5"   K   6c   5#   '   5%      5'      ?? 5(      $??1??6!    ?? Orientation$ 
Horizontal=?6.   .+?5)      ?? -   5        $ 
AddProduct??5.      $??Добавить??5)   !   $??5q?5*      $
??auto??5+      $
??Left=?5,      $??Center=?5-      5/      ?? 50      -   5        $ DeleteProduct??55      $??Удалить??50   !   $??5q?51      $
??auto??52      $
??Left=?53      $??Center=?54      56      ?? 5>      -   5        $ ReadProduct??5C      $2??,Обновить данные таблицы??5>   !   $??5q?5?      $
??auto??5@      $
??Left=?5A      $??Center=?5B      5D      5E      5F      5G      ?? 5H      $??Заказы??6   .??5I      ?  5J      ?? 5K      $??* ?6(   65   ?? 5L      $	??100 ?6(   67   .+?5N        -   5        $ OrderDG??5N      $ False??5O      $
 True??5P      $ Single=?5Q       5R        5S      $ ID??61   	 6=   ?? *	IdOrder+  5T      $# Фамилия клиента??61   	 6J   ?? *SurnameClient+  5U      $ Статус??61   	 6A   ?? *
NameStatus+  5V      $ ID сотрудника??61   	 6H   ?? *IdUser+  5W      $ Сумма заказа??61   	 6G   ?? *PriceOrders+5Y      ?? 5Z      $??1??6!   $ 
Horizontal=?6.   .+?5[      ?? -   5        $ AddOrder??5`      $??Добавить??5[   !   $??5q?5\      $
??auto??5]      $
??Left=?5^      $??Center=?5_      5a      ?? 5b      -	   5        $ btnDeleteOrder??5g      $??Удалить??5b   !   $??5q?5c      $
??auto??5d      $
??Left=?5e      $??Center=?5f      5h      ?? 5i      -
   5        $ btnUpdateOrder??5n      $5??/Редактировать информацию??5i   !   $??5q?5j      $
??auto??5k      $
??Left=?5l      $??Center=?5m      5o      ?? 5p      -   5        $ btnReadOrder??5u      $2??,Обновить данные таблицы??5p   !   $??5q?5q      $
??auto??5r      $
??Left=?5s      $??Center=?5t      5v      5w      5x      5y      5z      ?? 5{   
   -   5        $
 Exit??5?      $??1??5{      $??Bottom=?5|      $??Right=?5}      $??
Выйти??5~      $
??auto??5      $??5q?5?       ? Cursor$
 Hand??5?   $   5?      5?      5?      