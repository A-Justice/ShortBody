   M S B A M L   `   `   `  ����D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  5      S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  5      W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  5	      E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  5
           ShortBody.Pages.ClientPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ShortBody.Pages     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      8ctr.clr-namespace:ShortBody.Resources.UserControls  5      9an0clr-namespace:ShortBody.Resources.Helper_Methods  5	      0cv'clr-namespace:ShortBody.ValueConverters  5
      W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� ShowsNavigationUI  .  .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��7 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � $��2��6   $��	20,5,20,5q�6#   $��40��66      MaterialDesignPaper#���   5      .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��5,0,5,0q�5      .+�5       �� $��
SearchBy :��6   $��Center=�6.   $��17(�5!      �� 5"      -   5        $��cboSearchBox��5"   A   $��80��6   $��Center=�6&   $��5,0,5,0q�5#   5    �� Text 6   �� *
SearchBy+@�5$      �� 5%      $	��All��6'   �� 5&      $
��Name��6'   �� 5'      $��Email��6'   5)      �� 5+      -   5        $��txtSearchBox��5+   9   $	��150��6   $��10,0,5,0q�6'   ��5,      �� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 5.        BoderlessButton#��[ 6   $��17(�5/      $��5,0,5,0q�6(   ��50      �� *SearchClientCommand+.��6B   Search52      53      54      1   +ShortBody.Resources.UserControls.miniWindow  56   
   
������    
HeaderText$ All Clients��63   $��1��57      $��3��6&      CanClose .  	   Content	 59      � 5:       5;      �� 5<      $
��auto �6(   �� 5=      $
��241* �6(   .+�5?      �� $ 
Horizontal=�6!     myDirtyWhite#��[ 5@      .+�5A      �� -   5        $��5q�5A   "   
 � ToolTip$
 Add New Client��6-     b_Button#��[ 5B      .��6R   
Add Client5D      �� 5E      
�������$��1��61   $��5,5,5,5q�6;   �� 5G      $��5,5,5,5q�6"   #��[ 63   ��6U   �� *DeleteClientCommand+.��6}   Delete Client5I      5L      &   System.Windows.Controls.DataGrid  5N      -   5        
���   �   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5O      $��1��60   :   4ShortBody.Resources.Helper_Methods.DataGridExtension   HideAnnotatedColumns .    CanUserReorderColumns .    CanUserResizeColumns .    CanUserAddRows .     CanUserResizeRows .     CanUserSortColumns . $��13(�5Q   ?   ��5N       �� *
AllClients+$ PropertyChanged=�$ TwoWay=�5S      5T      5V        5X   
   -   5          Name$ AddClientWindow��5Y      1   +ShortBody.Resources.UserControls.miniWindow   Loaded$ AddClientWindow_Loaded��5Z      $��1��5X      $��1��6&   $ 
Add Client��66   $	��600��5Y   2   .	 5[      �  5\      �� 5]      $
��auto �6$   �� 5^      $
��241* �6$   �� 5_      $��10 �6$   .+�5a      �� $ 
Horizontal=�6   #��[ 5b      .+�5d      �� $��5,5,5,5q�6   #��[ 6/   $
 Clear Boxes��5f      ��64   �� *
ClearBoxes+.��5g      "  FontAwesome.WPF.ImageAwesome     Icon$ 
PaintBrush=�6*   $��20��6<   $��3,0,0,0q�6G   5i      5k      � 5m      $��1��6   $��2��6$   #���   65    � DataContext 6h   �� *	NewClient+ 5n      �� 5o      $
��auto �6(   �� 5p      $	��87* �6(    5r      �� 5s      $
��Auto �6+   �� 5t      $��* �6+   �� 5u      $
��Auto �6+   �� 5v      $��* �6+   .+�5x      ��   tb#��[ 6    $��5q�6w    �� TextAlignment$ Center=�5y   $   ���#CA5100$��4��6P   ��5x   <   �� *Error+$ PropertyChanged=� 5z   #   ��  �� RelativeSource ��  �� AncestorType" N� �� Mode$ FindAncestor=� �� Path$ DataContext��� 5|      $��5q�6!   $��1��6,   .+�5}      �� #��[ 6$   $��Name :��6@   $ Right=�6N   $��10q�6d   $��Center=�5~   $   �� 5      #��[ 6$   $��	Address :��6@   $ Right=�6Q   $��10q�6g   $��Center=�5�   $   �� 5�      #��[ 6$   $��City :��6@   $ Right=�6N   $��10q�6d   $��Center=�5�   $   5�      �� 5�      $��1��6!   $��5q�61   $��1��6<   .+�5�      �� $��	5,10,5,10q�68   ��6"   �� *Name+68   �� 5�      $��	5,10,5,10q�6<   ��6"   �� *	Address+6<   �� 5�      $��	5,10,5,10q�69   ��6"   �� *City+69   5�      �� 5�      $��2��6!   $��5q�61   $��1��6<   .+�5�      �� #��[ 6$   $��Phone :��6@   $ Right=�6O   $��10q�6e   $��Center=�5�   $   �� 5�      #��[ 6$   $��Email Adress :��6@   $ Right=�6V   $��10q�6l   $��Center=�5�   $   5�      �� 5�      $��3��6!   $��5q�61   $��1��6<   .+�5�      �� $��	5,10,5,10q�69   ��6"   �� *Phone+69   �� 5�      $��	5,10,5,10q�69   ��6"   �� *Email+69   �� 5�      $
��Save��6!   $��10q�60   $��70��6<    5�   !   ��  �� " N�$ FindAncestor=�$ DataContext���5�       �� *SaveNewClientCommand+5�      5�      5�      5�      5�      5�      