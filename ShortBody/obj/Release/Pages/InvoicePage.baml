   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  !    ShortBody.Pages.InvoicePage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:ShortBody.Pages     ?an0clr-namespace:ShortBody.Resources.Helper_Methods     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  8ctr.clr-namespace:ShortBody.Resources.UserControls  W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  0cv'clr-namespace:ShortBody.ValueConverters  -   .���   � RowDefinitions  �� $
��Auto ��� $
��Auto ��� $��* ��� $��7 � � ColumnDefinitions �� $��* ��� $
��Auto �.+�]� $��4��$��	20,5,20,5q�   MaterialDesignPaper#���   .+���   tb#��[ $��Invoice For :��$��Center=�$��5q��� -   $��cboInvoiceFor��$	��150��$��5q�$��5q� �� Text �� *
InvoiceFor+ �� UpdateSourceTrigger$ PropertyChanged=�.@��� $��Clients���� $��	Suppliers���� -   $��All Invoice Statement��  b_Button#��[ $��30,5,5,5q����� *ShowAllInvoices+��  �� Orientation$ 
Horizontal=�$��Center=�$��10,0,5,0q�$��Right=�.+��� $��
SearchBy :��$��Center=�$��17(��� -   $��cboSearchBox��$	��150��$��Center=�$��5,0,5,0q� �� *
SearchBy+@��� $	��All���� $��	Invoice #���� $��Remarks���� -   $��txtSearchBox��$	��150��$��10,0,5,0q����� *SearchString+$ PropertyChanged=� �� Mode$ TwoWay=���   BoderlessButton#��[ $��17(�$��5,0,5,0q����� *SearchInvoiceCommand+.��Search1   +ShortBody.Resources.UserControls.miniWindow  
������    
HeaderText$ All Invoices ��$��1��$��3��   CanClose .     Content �   �� $
��auto ��� $
��241* ��� $��10 �.+��� $ 
Horizontal=�  myDirtyWhite#��[ .+��� -   $��Add Invoice��$��5q�#��[ ���� *AddInvoiceCommand+�� 
�������$��1��$��5,5,1,5q��� $��1,5,5,5q�#��[ 	 � ToolTip$	 Delete Selected Invoice������ *DeleteInvoiceCommand+.��Delete Invoice�� 
�������$��1��$��5,5,1,5q��� -   $��1,5,5,5q�#��[ $	 View Invoice Statement������ *ViewInvoice+.��View Invoice Statement&   System.Windows.Controls.DataGrid  -   ��.  :   4ShortBody.Resources.Helper_Methods.DataGridExtension
   HideAnnotatedColumns
 . 
���   �   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * $��2��   CanUserAddRows .  $��1��   CanUserReorderColumns .    CanUserResizeColumns . $��5,0,5,5q�   CanUserResizeRows .     CanUserSortColumns . $��13(����� *For+$ PropertyChanged=�$ TwoWay=�   RowDetailsTemplate �� .R�  -	   ��.   	 white#��[    AutoGenerateColumns .  $ *  .    SubDataGridHeader   ColumnHeaderStyle# [ $��5,0,5,5q����� *
Invoices+$ TwoWay=�$ PropertyChanged=�   Columns 9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
Invoice No��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
Invoice_No+  $
 Date�� �� *Date+ �� 	Converter -  'ShortBody.ValueConverters.DateFormatter    $ PurchaseOrder No�� �� *PurchaseOrder_No+  $ ProjectSite�� �� *ProjectSite+  $ 
Waybill No�� �� *
WayBill_No+  $ Description��  elementStyle   ElementStyle# [   editingElementStyle   EditingElementStyle# [  �� *Description+  $ Amount�� �� *Amount+ -	   'ShortBody.ValueConverters.DToSConverter	    $ 
Vat+Nhil %�� �� *
Vat_Nhil+  $ 	Vat Value�� �� *
VatValue+ 	    $ Total Amount�� �� *TotalAmount+ 	    $ Remarks�� �� *	Remarks+  -
     Name$ AddInvoiceWindow��1
   +ShortBody.Resources.UserControls.miniWindow 
  Loaded$ AddInvoiceWindow_Loaded��$��1��$��1��$ Add Invoice��$	��600��. � #���     �� $
��auto ��� $
��auto ��� $��* �.+��� $ 
Horizontal=�#��[ .+��� $��10,5,5,5q�#��[ ���� *ClearCommand+.���� $ 
Horizontal=�.+�"  FontAwesome.WPF.ImageAwesome     Icon$ 
PaintBrush=�$��20���� 
�������$��1��$��5,5,1,5q��� #��[ $��5q� �� TextAlignment$ Center=����#CA5100$��4������ *Error+$ PropertyChanged=� � DataContext ��  �� RelativeSource ��   �� AncestorType"  N�! �� Mode$! FindAncestor=�" �� Path$" DataContext�� $��2�� �� *InvoiceHelper+  �� $
��Auto ��� $
��243* � �� $
��Auto ��� $��* ��� $
��Auto ��� $��* �.+��� $ 
Horizontal=�$��4��$��5q� ��  �� "  N�$! FindAncestor=�$" DataContext�.+��� #��[ $��Center=�$��5q����� *
InvoiceFor+$ PropertyChanged=� (   "ShortBody.ValueConverters.SRemover  �� #��[ $	��150������ *NameForCurrent+$ PropertyChanged=� .   (ShortBody.ValueConverters.dummyConverter  �� $��5q�$��2��$��1��.+��� #��[ $��Invoice Number :��$ Right=�$��10q�$��Center=��� #��[ $��Purchase Order _No :��$ Right=�$��10q�$��Center=��� #��[ $��ProjectSite :��$ Right=�$��10q�$��Center=��� #��[ $��Way Bill _No :��$ Right=�$��10q�$��Center=��� $��1��$��5q�$��1��.+��� $��	5,10,5,10q����� *
Invoice_No+�� $��	5,10,5,10q����� *PurchaseOrder_No+�� $��	5,10,5,10q����� *ProjectSite+�� $��	5,10,5,10q����� *
WayBill_No+�� $��2��$��5q�$��1��.+��� #��[ $��Description :��$ Right=�$��10q�$��Center=��� #��[ $��Amount :��$ Right=�$��10q�$��Center=��� #��[ $��
VAT+NHIL :��$ Right=�$��10q�$��Center=��� #��[ $��	Remarks :��$ Right=�$��10q�$��Center=��� $��3��$��5q�$��1��.+��� $��	5,10,5,10q����� *Description+�� $��	5,10,5,10q����� *Amount+�� $��	5,10,5,10q����� *
Vat_Nhil+�� $��	5,10,5,10q� �� *	Remarks+.@��� $
��Paid���� $��UnPaid���� $
��Save��$��10q� ��  �� "  N�$! FindAncestor=�$" DataContext����� *SaveInvoice+