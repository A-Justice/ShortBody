   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters      ShortBody.Pages.UsersPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:ShortBody.Pages     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  8ctr.clr-namespace:ShortBody.Resources.UserControls  W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  9an0clr-namespace:ShortBody.Resources.Helper_Methods  0cv'clr-namespace:ShortBody.ValueConverters  .���   � RowDefinitions  �� $
��Auto ��� $
��Auto ��� $��* ��� $��7 � � ColumnDefinitions �� $��* ��� $
��Auto �.+�� $��2��$��	20,5,20,5q�$��40��   MaterialDesignPaper#���   .+���  �� Orientation$ 
Horizontal=�$��Center=�$��5,0,5,0q�.+��� $��
SearchBy :��$��Center=�$��17(��� -   $��cboSearchBox��$	��150��$��Center=�$��5,0,5,0q� �� Text �� *
SearchBy+@��� $	��All���� $��	FirstName���� $��LastName���� -   $��txtSearchBox��$	��150��$��10,0,5,0q����� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=���   BoderlessButton#��[ $��17(�$��5,0,5,0q����� *SearchUserCommand+.��Search1   +ShortBody.Resources.UserControls.miniWindow  
������    
HeaderText$ 	All Users��$��1��$��3��   CanClose .     Content �   �� $
��auto ��� $
��241* ��� $��10 �.+�]�   myDirtyWhite#��[ .+��� -   $��5q�	 � ToolTip$	 Add New User��  b_Button#��[ .��"  FontAwesome.WPF.ImageAwesome  
   Icon$
 UserPlus=�$��20���� 
�������$��1��$��5,5,1,5q��� $��1,5,5,5q�#��[ ���� *DeleteUserCommand+.���� $ 
Horizontal=�$	 Delete User��.+�  $
 Trash=�$��20���� -   $��5q�$"	 Change Selected User's Image��$��Right=�#��[ ���� *ChangeUserImageCommand+.��  $
 Image=�$��20��&   System.Windows.Controls.DataGrid  -   
���   �   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * $��2��   CanUserAddRows .  $��1��:   4ShortBody.Resources.Helper_Methods.DataGridExtension   HideAnnotatedColumns .    CanUserReorderColumns .    CanUserResizeColumns .    CanUserResizeRows .     CanUserSortColumns . $��13(����� *
AllUsers+$ PropertyChanged=�$ TwoWay=�  -     Name$ AddUserWindow��1   +ShortBody.Resources.UserControls.miniWindow   Loaded$ AddUserWindow_Loaded��$��1��$��1��$ Add User��$	��600��. �   �� $
��auto ��� $
��241* ��� $��10 �.+�]� #��[ .+��� $��5,5,5,5q�#��[ $	 Clear Boxes������ *
ClearBoxes+.��  $
 
PaintBrush=�$��20��$��3,0,0,0q���   tb#��[ $��5q�$��2��$��Center=� �� TextAlignment$ Center=����#CA5100$��2������ *Error+$ PropertyChanged=� � DataContext ��  �� RelativeSource ��  �� AncestorType" N� �� Mode$ FindAncestor=� �� Path$ DataContext�� $��1��$��2��#���    �� *	NewUser+  �� $
��auto ��� $	��87* � �� $
��Auto ��� $��* ��� $
��Auto ��� $��* �.+��� $	��100��$��1��$��10q����� *	UserImage+$ PropertyChanged=�$ TwoWay=� ��  �� " N�$ FindAncestor=�$ DataContext��� $��Center=� ��  �� " N�$ FindAncestor=�$ DataContext�.+��� #��[ $��Image :��$��Right=��� $��Browse��#��[ $��10q�$��70��$��Right=����� *BrowseCommand+�� $��5q�$��1��.+��� #��[ $��FirstName :��$ Right=�$��10q�$��Center=�$��30���� #��[ $��
LastName :��$ Right=�$��10q�$��Center=�$��30���� $��1��$��5q�$��1��.+��� $��	5,10,5,10q����� *	FirstName+�� $��	5,10,5,10q����� *
LastName+�� $��2��$��5q�$��1��.+��� #��[ $��
Password :��$ Right=�$��10q�$��Center=�$��30���� $��3��$��5q�$��1��.+��� $��	5,10,5,10q����� *
Password+�� $
��Save��$��50�� ��  �� " N�$ FindAncestor=�$ DataContext����� *SaveNewUserCommand+