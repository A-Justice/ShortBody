   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  #    ShortBody.Pages.QuotationPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:ShortBody.Pages     ?an0clr-namespace:ShortBody.Resources.Helper_Methods     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  8ctr.clr-namespace:ShortBody.Resources.UserControls  W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  0cv'clr-namespace:ShortBody.ValueConverters  -     N� ShowsNavigationUI  .  .���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��* ��� $��7 � � ColumnDefinitions �� $��* ��� $
��Auto �.+�� $��2��$��	20,5,20,5q�$��40��   MaterialDesignPaper#���   .+���  �� Orientation$ 
Horizontal=�$��Center=�$��5,0,5,0q�.+��� $��
SearchBy :��$��Center=�$��17(��� -   $��cboSearchBox��$	��150��$��Center=�$��5,0,5,0q� �� Text �� *
SearchBy+@��� $	��All���� $��Quote #���� $��
Job Status���� $��Remarks���� -   $��txtSearchBox��$	��150��$��10,0,5,0q����� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=���   BoderlessButton#��[ $��17(�$��5,0,5,0q����� *SearchQuotationCommand+.��Search1   +ShortBody.Resources.UserControls.miniWindow  
������    
HeaderText$ All Clients Quotations��$��1��$��3��   CanClose .  	   Content	 �  �� $
��auto ��� $
��241* ��� $��10 �.+��� $ 
Horizontal=�  myDirtyWhite#��[ $��0,-5,0,5q�.+��� -   $��5q�  b_Button#��[ $��Add Quotation������ *AddQuotationCommand+�� $��1,5,5,5q�#��[ $��Delete Quotation������ *DeleteQuotationCommand+�� -   $��1,5,5,5q�#��[ $��View Selected Quotation������ *ViewQuotation+�� -   $��1,5,5,5q�#��[ $��Client's Quotations������ *ClientQuotationCommand+�� -   $��1,5,5,5q�#��[ $��All Quotations��&   System.Windows.Controls.DataGrid  -   ��.  :   4ShortBody.Resources.Helper_Methods.DataGridExtension
   HideAnnotatedColumns
 . 
���   �   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * $��2��   CanUserAddRows .  $��1��   CanUserReorderColumns .    CanUserResizeColumns .    CanUserResizeRows .     CanUserSortColumns . $��13(����� *	Clients+$ PropertyChanged=�$ TwoWay=�   RowDetailsTemplate �� .R�  -	      AutoGenerateColumns .   .  $��5,0,5,5q�
�������  SubDataGridHeader   ColumnHeaderStyle# [ ���� *
Quotations+$ PropertyChanged=�   Columns 9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Quotation N0��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *QuoteNumber+  $
 Date�� �� *	QuoteDate+ �� 	Converter -  'ShortBody.ValueConverters.DateFormatter    $ 	Requester�� �� *	Requester+  $ ServiceWanted��  elementStyle   ElementStyle# [   editingElementStyle   EditingElementStyle# [  �� *ServiceWanted+  $ ProjectSite�� �� *ProjectSite+  $ Amount�� �� *Amount+ -	   'ShortBody.ValueConverters.DToSConverter	    $ 	Vat+Nhil%�� �� *
Vat_Nhil+  $ VatValue�� �� *
VatValue+ 	    $ TotalAmount�� �� *TotalAmount+ 	    $ Remarks�� �� *	Remarks+  $ 	JobStatus�� �� *	JobStatus+  -
     Name$ AddQuotationWindow��1
   +ShortBody.Resources.UserControls.miniWindow 
  Loaded$ AddQuotation_Loaded��$��1��$��1��$ Add Quotation��$	��600��.	 �  �� $
��auto ��� $
��241* ��� $��10 �.+�]� #��[ .+��� $��10,5,5,5q�#��[ ���� *
ClearBoxes+.��"  FontAwesome.WPF.ImageAwesome     Icon$ 
PaintBrush=�$��20��$��3,0,0,0q��� 
�������$��1��$��5,5,1,5q���   tb#��[ $��1��$��4��$��5q� �� TextAlignment$ Center=����#CA5100���� *Error+$ PropertyChanged=� � DataContext ��  �� RelativeSource ��   �� AncestorType"  >�! �� Mode$! FindAncestor=�" �� Path$" DataContext�� #���   $��1��$��2�� �� *NewQuotation+ �� $
��auto ��� $
��auto ��� $��* � �� $
��Auto ��� $��* ��� $
��Auto ��� $��* �.+��� $ 
Horizontal=�$��4��$��5q� ��  �� "  N�$! FindAncestor=�$" DataContext�.+��� #��[ $��Quotation for :��$��Center=�$��5q��� #��[ $ Center=� �� *SelectedClient+���� *Name+$ PropertyChanged=�$ TwoWay=��� $��5q�$��2��.+��� #��[ $��Quotation Number:��$ Right=�$��10q�$��Center=��� #��[ $��Project Site :��$ Right=�$��10q�$��Center=��� #��[ $��Machine Number :��$ Right=�$��10q�$��Center=��� #��[ $��Service Wanted :��$ Right=�$��10q�$��Center=��� $��1��$��5q�$��2��.+��� $��	5,10,5,10q����� *QuoteNumber+$ PropertyChanged=�$ TwoWay=��� $��	5,10,5,10q����� *ProjectSite+�� $��	5,10,5,10q����� *MachineNumber+�� $��	5,10,5,10q����� *ServiceWanted+�� $��2��$��5q�$��2��.+��� #��[ $��
VAT+NHIL :��$ Right=�$��10q�$��Center=��� #��[ $��Job Status :��$ Right=�$��10q�$��Center=��� #��[ $��Requester :��$ Right=�$��10q�$��Center=��� $��3��$��5q�$��2��.+��� $��	5,10,5,10q����� *
Vat_Nhil+�� # �� 
IsEditable# . $��	5,10,5,10q� �� *	JobStatus+.@��� $��	Completed���� $��Work In Progress���� $��Yet To Start���� $��	5,10,5,10q����� *	Requester+�� $
��Save��$��
10,20,10,0q� ��  �� "  N�$! FindAncestor=�$" DataContext����� *SaveQuotation+