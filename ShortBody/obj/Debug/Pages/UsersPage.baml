   M S B A M L   `   `   `  ����D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  5      S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  5      W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  5
      E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  5          ShortBody.Pages.UsersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ShortBody.Pages     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      8ctr.clr-namespace:ShortBody.Resources.UserControls  5      W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  5	      9an0clr-namespace:ShortBody.Resources.Helper_Methods  5
      0cv'clr-namespace:ShortBody.ValueConverters  5      .��5      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��7 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � $��2��6   $��	20,5,20,5q�6#   $��40��66      MaterialDesignPaper#���   5      .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��5,0,5,0q�5      .+�5       �� $��
SearchBy :��6   $��Center=�6.   $��17(�5!      �� 5"      -   5        $��cboSearchBox��5"   B   $	��150��6   $��Center=�6'   $��5,0,5,0q�5$   5    �� Text 6   �� *
SearchBy+@�5%      �� 5&      $	��All��6'   �� 5'      $��	FirstName��6'   �� 5(      $��LastName��6'   5*      �� 5,      -   5        $��txtSearchBox��5,      $	��150��6/   $��10,0,5,0q�6;   ��6M   �� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 5.        BoderlessButton#��[ 6   $��17(�5/      $��5,0,5,0q�6(   ��50      �� *SearchUserCommand+.��6@   Search52      53      54      1   +ShortBody.Resources.UserControls.miniWindow  57   
   
������    
HeaderText$ 	All Users��63   $��1��58      $��3��6&      CanClose .     Content 5:      � 5;        5<      �� 5=      $
��auto �6(   �� 5>      $
��241* �6(   �� 5?      $��10 �6(   .+�5A      ]�   myDirtyWhite#��[ 5B      .+�5C      �� -   5        $��5q�5C   "   	 � ToolTip$	 Add New User��6-     b_Button#��[ 5D      .��5E      "  FontAwesome.WPF.ImageAwesome  
   Icon$
 UserPlus=�6.   $��20��6>   5F      �� 5G      
�������$��1��61   $��5,5,1,5q�6;   �� 5I      $��1,5,5,5q�6"   #��[ 63   ��6U   �� *DeleteUserCommand+.��5J      �� $ 
Horizontal=�6)   $	 Delete User��6B   .+�5K   "     $
 Trash=�62   $��20��6?   5M      5N      �� 5P      -   5        $��5q�5P   "   $"	 Change Selected User's Image��6-   $��Right=�6T   #��[ 5R      ��5Q   "   �� *ChangeUserImageCommand+.��5S        $
 Image=�6.   $��20��6;   5T      5U      &   System.Windows.Controls.DataGrid  5W      -   5        
���   �   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5X      $��2��6/      CanUserAddRows .  $��1��6W   :   4ShortBody.Resources.Helper_Methods.DataGridExtension   HideAnnotatedColumns .    CanUserReorderColumns .    CanUserResizeColumns .    CanUserResizeRows .     CanUserSortColumns . $��13(�5Z   ?   ��5W       �� *
AllUsers+$ PropertyChanged=�$ TwoWay=�5\      5]      5_        5a   
   -   5          Name$ AddUserWindow��5b      1   +ShortBody.Resources.UserControls.miniWindow   Loaded$ AddUserWindow_Loaded��5c      $��1��5a      $��1��6&   $ Add User��66   $	��600��5b   0   . 5d      �   5e      �� 5f      $
��auto �6$   �� 5g      $
��241* �6$   �� 5h      $��10 �6$   .+�5j      ]� #��[ 5k      .+�5m      �� $��5,5,5,5q�6   #��[ 6/   $	 Clear Boxes��5n      ��64   �� *
ClearBoxes+.��5o        $
 
PaintBrush=�6*   $��20��6<   $��3,0,0,0q�6G   5q      �� 5r        tb#��[ 6    $��5q�6w   $��2��5s       $��Center=�60    �� TextAlignment$ Center=�5t   $   ���#CA5100$��2��6P   ��5r   <   �� *Error+$ PropertyChanged=� � DataContext 5u   $   ��  �� RelativeSource ��  �� AncestorType" N� �� Mode$ FindAncestor=� �� Path$ DataContext�5x      � 5z      $��1��6   $��2��6$   #���   65    6h   �� *	NewUser+  5{      �� 5|      $
��auto �6(   �� 5}      $	��87* �6(    5      �� 5�      $
��Auto �6+   �� 5�      $��* �6+   �� 5�      $
��Auto �6+   �� 5�      $��* �6+   .+�5�      �� $	��100��6   $��1��6)   $��10q�69   ��5�      �� *	UserImage+$ PropertyChanged=�$ TwoWay=� 6j   ��  �� " N�$ FindAncestor=�$ DataContext��� 5�      $��Center=�6"    6>   ��  �� " N�$ FindAncestor=�$ DataContext�.+�5�      �� #��[ 6$   $��Image :��6@   $��Right=�6O   �� 5�      $��Browse��6!   #��[ 62   $��10q�5�   !   $��70��6-   $��Right=�68   ��5�   T   �� *BrowseCommand+5�   8   5�      �� 5�      $��5q�6!   $��1��6,   .+�5�      �� #��[ 6$   $��FirstName :��6@   $ Right=�6S   $��10q�6i   $��Center=�5�   $   $��30��6?   �� 5�      #��[ 6$   $��
LastName :��6@   $ Right=�6R   $��10q�6h   $��Center=�5�   $   $��30��6?   5�      �� 5�      $��1��6!   $��5q�61   $��1��6<   .+�5�      �� $��	5,10,5,10q�6>   ��6"   �� *	FirstName+6>   �� 5�      $��	5,10,5,10q�6=   ��6"   �� *
LastName+6=   5�      �� 5�      $��2��6!   $��5q�61   $��1��6<   .+�5�      �� #��[ 6$   $��
Password :��6@   $ Right=�6R   $��10q�6h   $��Center=�5�   $   $��30��6?   5�       �� 5�      $��3��6!   $��5q�61   $��1��6<   .+�5�      �� $��	5,10,5,10q�6=   ��6"   �� *
Password+6=   �� 5�      $
��Save��6!   $��50��5�   H    5�   0   ��  �� " N�$ FindAncestor=�$ DataContext���5�   !   �� *SaveNewUserCommand+6H   5�      5�      5�      5�      5�      5�      