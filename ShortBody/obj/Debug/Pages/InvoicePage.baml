   M S B A M L   `   `   `  ����D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  5      W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  5      S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  5
      E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  5      !    ShortBody.Pages.InvoicePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ShortBody.Pages     5      ?an0clr-namespace:ShortBody.Resources.Helper_Methods     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5	      8ctr.clr-namespace:ShortBody.Resources.UserControls  5
      W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  5      0cv'clr-namespace:ShortBody.ValueConverters  5      -   5        .��5      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��7 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ]� $��4��6   $��	20,5,20,5q�6)      MaterialDesignPaper#���   5      .+�5      ��   tb#��[ 6   $��Invoice For :��64   $��Center=�6I   $��5q�6d   �� 5!      -   5        $��cboInvoiceFor��5!      $	��150��6,   $��5q�68   $��5q�5"       �� Text 5!   C   �� *
InvoiceFor+ �� UpdateSourceTrigger$ PropertyChanged=�.@�5#      �� $��Clients��6   �� 5$      $��	Suppliers��6   5%      �� 5'      -   5        $��All Invoice Statement��5'        b_Button#��[ 65   $��30,5,5,5q�6W   ��5(   /   �� *ShowAllInvoices+�� 5*       �� Orientation$ 
Horizontal=�6   $��Center=�62   $��10,0,5,0q�5+      $��Right=�5,      .+�5-      �� $��
SearchBy :��6   $��Center=�6.   $��17(�5.      �� 5/      -   5        $��cboSearchBox��50   5   $	��150��5/      $��Center=�6'   $��5,0,5,0q�50   z    6   �� *
SearchBy+@�51      �� 52      $	��All��6'   �� 53      $��	Invoice #��6'   �� 54      $��Remarks��6'   56      �� 58      -   5        $��txtSearchBox��58      $	��150��6.   $��10,0,5,0q�6:   ��6L   �� *SearchString+$ PropertyChanged=� �� Mode$ TwoWay=��� 5:        BoderlessButton#��[ 6   $��17(�5;      $��5,0,5,0q�6(   ��5<      �� *SearchInvoiceCommand+.��6C   Search5>      5?      5A      1   +ShortBody.Resources.UserControls.miniWindow  5C   
   
������    
HeaderText$ All Invoices ��63   $��1��5D      $��3��6&      CanClose .     Content 5F      � 5G        5H      �� 5I      $
��auto �6(   �� 5J      $
��241* �6(   �� 5K      $��10 �6(   .+�5M      �� $ 
Horizontal=�6!     myDirtyWhite#��[ 5N      .+�5O      �� -   5        $��Add Invoice��5O   !   $��5q�67   #��[ 5Q      ��5P   ;   �� *AddInvoiceCommand+5Q      �� 5R      
�������$��1��61   $��5,5,1,5q�6;   �� 5T      $��1,5,5,5q�6"   #��[ 63   	 � ToolTip$	 Delete Selected Invoice��5U   !   ��6C   �� *DeleteInvoiceCommand+.��6l   Delete Invoice5W      �� 5Y      
�������$��1��61   $��5,5,1,5q�6;   �� 5\      -   5        $��1,5,5,5q�5\   !   #��[ 62   $	 View Invoice Statement��5]   "   ��5^   ;   �� *ViewInvoice+.��6[   View Invoice Statement5`      5a      &   System.Windows.Controls.DataGrid  5c      -   5        ��.  :   4ShortBody.Resources.Helper_Methods.DataGridExtension
   HideAnnotatedColumns
 . 
���   �   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5d      $��2��6.      CanUserAddRows .  $��1��6W      CanUserReorderColumns .    CanUserResizeColumns . $��5,0,5,5q�5e   D      CanUserResizeRows .     CanUserSortColumns . $��13(�5f   ?   ��5c   v   �� *For+$ PropertyChanged=�$ TwoWay=�   RowDetailsTemplate 5g      �� 5h      .R�5j   "     -	   5        ��.   	 white#��[ 5j   �      AutoGenerateColumns .  $ * 5k   z    .    SubDataGridHeader   ColumnHeaderStyle# [ 5l   B   $��5,0,5,5q�6y   ��5j   R   �� *
Invoices+$ TwoWay=�$ PropertyChanged=�   Columns 5m   &   9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  5n   *   ,  &System.Windows.Controls.DataGridColumn   Header$ 
Invoice No��6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6\   �� *
Invoice_No+6}     5o   *   $
 Date��6H    6V   �� *Date+ �� 	Converter -  'ShortBody.ValueConverters.DateFormatter  6�     5p   *   $ PurchaseOrder No��6H    6b   �� *PurchaseOrder_No+6�     5q   *   $ ProjectSite��6H    6]   �� *ProjectSite+6     5r   *   $ 
Waybill No��6H    6\   �� *
WayBill_No+6}     5s   *   $ Description��6H     elementStyle   ElementStyle# [ 6}     editingElementStyle   EditingElementStyle# [ 6�    6]   �� *Description+6�     5t   *   $ Amount��6H    6X   �� *Amount+ -	   'ShortBody.ValueConverters.DToSConverter	  6�     5u   *   $ 
Vat+Nhil %��6H    6\   �� *
Vat_Nhil+6{     5v   *   $ 	Vat Value��6H    6[   �� *
VatValue+ 	  6�     5w   *   $ Total Amount��6H    6^   �� *TotalAmount+ 	  6�     5x   *   $ Remarks��6H    6Y   �� *	Remarks+6w   5{   "   5}      5      5�      5�        5�   
   -
   5          Name$ AddInvoiceWindow��5�      1
   +ShortBody.Resources.UserControls.miniWindow 
  Loaded$ AddInvoiceWindow_Loaded��5�      $��1��5�      $��1��6&   $ Add Invoice��66   $	��600��5�   5   . 5�      � #���   6     5�      �� 5�      $
��auto �6$   �� 5�      $
��auto �6$   �� 5�      $��* �6$   .+�5�      �� $ 
Horizontal=�6   #��[ 5�      .+�5�      �� $��10,5,5,5q�6   #��[ 60   ��5�      �� *ClearCommand+.��5�      �� $ 
Horizontal=�6%   .+�5�      "  FontAwesome.WPF.ImageAwesome     Icon$ 
PaintBrush=�6.   $��20��6@   5�      5�      �� 5�      
�������$��1��6-   $��5,5,1,5q�67   5�      �� 5�      #��[ 6   $��5q�6s    �� TextAlignment$ Center=�5�   $   ���#CA5100$��4��6P   ��5�   8   �� *Error+$ PropertyChanged=� � DataContext 5�   #   ��  �� RelativeSource ��   �� AncestorType"  N�! �� Mode$! FindAncestor=�" �� Path$" DataContext�� 5�      $��2��6    6$   �� *InvoiceHelper+  5�      �� 5�      $
��Auto �6(   �� 5�      $
��243* �6(    5�      �� 5�      $
��Auto �6+   �� 5�      $��* �6+   �� 5�      $
��Auto �6+   �� 5�      $��* �6+   .+�5�      �� $ 
Horizontal=�6!   $��4��6:   $��5q�6N    6Y   ��  �� "  N�$! FindAncestor=�$" DataContext�.+�5�      �� #��[ 6$   $��Center=�6�   $��5q�6�   ��6@   �� *
InvoiceFor+$ PropertyChanged=� (   "ShortBody.ValueConverters.SRemover  6�   �� 5�      #��[ 6$   $	��150��6@   ��6M   �� *NameForCurrent+$ PropertyChanged=� .   (ShortBody.ValueConverters.dummyConverter  5�      �� 5�      $��5q�6!   $��2��6,   $��1��6>   .+�5�      �� #��[ 6$   $��Invoice Number :��6@   $ Right=�6X   $��10q�6n   $��Center=�5�   $   �� 5�      #��[ 6$   $��Purchase Order _No :��6@   $ Right=�6\   $��10q�6r   $��Center=�5�   $   �� 5�      #��[ 6$   $��ProjectSite :��6@   $ Right=�6U   $��10q�6k   $��Center=�5�   $   �� 5�      #��[ 6$   $��Way Bill _No :��6@   $ Right=�6V   $��10q�6l   $��Center=�5�   $   5�      �� 5�      $��1��6!   $��5q�61   $��1��6=   .+�5�      �� $��	5,10,5,10q�6?   ��6"   �� *
Invoice_No+6?   �� 5�      $��	5,10,5,10q�6E   ��6"   �� *PurchaseOrder_No+6E   �� 5�      $��	5,10,5,10q�6@   ��6"   �� *ProjectSite+6@   �� 5�      $��	5,10,5,10q�6?   ��6"   �� *
WayBill_No+6?   5�      �� 5�      $��2��6!   $��5q�61   $��1��6=   .+�5�      �� #��[ 6$   $��Description :��6@   $ Right=�6U   $��10q�6k   $��Center=�5�   $   �� 5�      #��[ 6$   $��Amount :��6@   $ Right=�6P   $��10q�6f   $��Center=�5�   $   �� 5�      #��[ 6$   $��
VAT+NHIL :��6@   $ Right=�6R   $��10q�6h   $��Center=�5�   $   �� 5�      #��[ 6$   $��	Remarks :��6@   $ Right=�6Q   $��10q�6g   $��Center=�5�   $   5�      �� 5�      $��3��6!   $��5q�61   $��1��6<   .+�5�      �� $��	5,10,5,10q�6@   ��6"   �� *Description+6@   �� 5�      $��	5,10,5,10q�6;   ��6"   �� *Amount+6;   �� 5�      $��	5,10,5,10q�6#   ��66   �� *
Vat_Nhil+�� 5�      $��	5,10,5,10q�6=    6#   �� *	Remarks+.@�5�      �� $
��Paid��6+   �� 5�      $��UnPaid��6+   5�      �� 5�      $
��Save��6!   $��10q�60    5�   !   ��  �� "  N�$! FindAncestor=�$" DataContext���5�   !   �� *SaveInvoice+5�      5�      5�      5�      5�      5�      