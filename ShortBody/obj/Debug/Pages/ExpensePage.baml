   M S B A M L   `   `   `  ����D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  5      1clr-namespace:ShortBody.PagesShortBody.Pages  5      S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  5	      E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  5      !    ShortBody.Pages.ExpensePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?an0clr-namespace:ShortBody.Resources.Helper_Methods     5      /localclr-namespace:ShortBody.Pages     5      >ctr.clr-namespace:ShortBody.Resources.UserControls     5	      W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  5
      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      0cv'clr-namespace:ShortBody.ValueConverters  5      .��5      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��7 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � $��2��6   $��	20,5,20,5q�6#   $��40��66      MaterialDesignPaper#���   5      .+�5       ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��5,0,5,0q�5!      .+�5#      �� $��
SearchBy :��6   $��Center=�6.   $��17(�5$      �� 5%      -   5        $��cboSearchBox��5%   B   $	��150��6   $��Center=�6'   $��5,0,5,0q�5'   5    �� Text 6   �� *
SearchBy+@�5(      �� 5)      $	��All��6'   �� 5*      $��P-Voucher #��6'   5,      �� 5.      -   5        $��txtSearchBox��5.      $	��150��6/   $��10,0,5,0q�6;   ��6M   �� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 50        BoderlessButton#��[ 6   $��17(�51      $��5,0,5,0q�6(   ��52      �� *SearchExpenseCommand+.��6C   Search54      55      56      1   +ShortBody.Resources.UserControls.miniWindow  5:   
   
������    
HeaderText$ All Expenses��63   $��1��5;      $��3��6&      CanClose .     Content 5=      � 5>        5?      �� 5@      $
��auto �6(   �� 5A      $
��241* �6(   �� 5B      $��10 �6(   .+�5D      �� $ 
Horizontal=�6!     myDirtyWhite#��[ 5E      .+�5F      �� -   5        $��5q�5F   "   	 � ToolTip$	 Add New Expense��6-     b_Button#��[ 5G      .��5H      "  FontAwesome.WPF.ImageAwesome  
   Icon$
 UserPlus=�6.   $��20��6>   5I      �� 5J      
�������$��1��61   $��5,5,1,5q�6;   �� 5L      $��1,5,5,5q�6"   #��[ 63   ��6U   �� *DeleteExpenseCommand+.��5M      �� $ 
Horizontal=�6)   $	 Delete Expense��6B   .+�5N   "     $
 Trash=�62   $��20��6?   5P      5Q      �� 5S      
�������$��1��61   $��5,5,1,5q�6;   �� 5U      -   5        $��1,5,5,5q�5U   "   #��[ 63   $��Expenses Statement��6s   5W      &   System.Windows.Controls.DataGrid  5Y      -   5           AutoGenerateColumns .  
���   �   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5Z      $��1��60   $��2��6=      CanUserAddRows .     CanUserReorderColumns .    CanUserResizeColumns .    CanUserResizeRows .     CanUserSortColumns . $��13(�5\   ?   ��5Y   ;   �� *AllExpenses+$ PropertyChanged=�$ OneWay=�   Columns 5]      9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  5^      ,  &System.Windows.Controls.DataGridColumn   Header$ PaymentVoucherNumber��6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Z   �� *PaymentVoucherNumber+6�     5_      $
 Date��6<    6J   �� *Date+ �� 	Converter -  'ShortBody.ValueConverters.DateFormatter  6�     5`      $ Description��6<     elementStyle   ElementStyle# [ 6q     editingElementStyle   EditingElementStyle# [ 6�    6Q   �� *Description+6�     5a      $ Amount��6<    6L   �� *Amount+ -	   'ShortBody.ValueConverters.DToSConverter	  6�   5d      5e      5g        5i   
   -   5          Name$ AddExpenseWindow��5j      1
   +ShortBody.Resources.UserControls.miniWindow 
  Loaded$ AddExpenseWindow_Loaded��5k      $��1��5i      $��1��6&   $ Add Expense��66   $	��600��5j   3   . 5l      �   5m      �� 5n      $
��auto �6$   �� 5o      $
��241* �6$   �� 5p      $��10 �6$   .+�5r      �� $ 
Horizontal=�6   #��[ 5s      .+�5u      �� $��10,5,5,5q�6   #��[ 60   $	 Clear Boxes��5v      $��E��6S   ��64   �� *
ClearBoxes+.��5w      �� $ 
Horizontal=�6%   .+�5x        $
 
PaintBrush=�6.   $��20��6@   5z      5{      �� 5}      
�������$��1��6-   $��5,5,1,5q�67   5�      � 5�      $��1��6   #���   6$   $��2��6z    � DataContext 6W   �� *
NewExpense+  5�      �� 5�      �� 5�      $��6* �6(    5�      �� 5�      $
��Auto �6+   �� 5�      $��* �6+   �� 5�      $
��Auto �6+   �� 5�      $��* �6+   .+�5�      ��   tb#��[ 6    $��4��6<   $��5q�6�    �� TextAlignment$ Center=�5�   $   ���#CA5100��5�   P   �� *Error+$ PropertyChanged=� 5�   $   ��  �� RelativeSource ��  �� AncestorType" >� �� Mode$ FindAncestor=� �� Path$ DataContext��� 5�      $��5q�6!   $��1��6,   .+�5�      �� #��[ 6$   $��Payment Voucher_No :��6@   $ Right=�6\   $��10q�6r   $��Center=�5�   $   5�   /   �� 5�      $��1��6!   $��5q�61   $��1��6<   .+�5�      �� $��	5,10,5,10q�6H   ��6"   �� *PaymentVoucherNumber+6H   5�      �� 5�      $��2��6!   $��5q�61   $��1��6<   .+�5�      �� #��[ 6$   $��Description :��6@   $ Right=�6U   $��10q�6k   $��Center=�5�   $   �� 5�      #��[ 6$   $��Amount :��6@   $ Right=�6P   $��10q�6f   $��Center=�5�   $   5�      �� 5�      $��3��6!   $��5q�61   $��1��6<   .+�5�      �� $��	5,10,5,10q�6@   ��6"   �� *Description+6@   �� 5�      $��	5,10,5,10q�6:   ��6"   �� *Amount+6:   �� 5�      $
��Save��6!   $��50��5�   H    5�   0   ��  �� "  $ FindAncestor=�$ DataContext���5�   !   �� *SaveExpenseCommand+6H   5�      5�      5�      5�      5�      5�      