   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  '    !ShortBody.Pages.PaymentAdvicePage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:ShortBody.Pages     W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  8ctr.clr-namespace:ShortBody.Resources.UserControls  9an0clr-namespace:ShortBody.Resources.Helper_Methods  0cv'clr-namespace:ShortBody.ValueConverters    N� Title$  PaymentAdvicePage��.���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��* ��� $��7 � � ColumnDefinitions �� $��* ��� $
��Auto �.+�� $��2��$��	20,5,20,5q�$��40��   MaterialDesignPaper#���   .+���  �� Orientation$ 
Horizontal=�$��Center=�$��5,0,5,0q�.+��� $��
SearchBy :��$��Center=�$��17(��� -   $��cboSearchBox��$	��150��$��Center=�$��5,0,5,0q� �� Text �� *
SearchBy+@��� $	��All���� $��Company Name���� $��Cheque #���� -   $��txtSearchBox��$	��150��$��10,0,5,0q����� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=���   BoderlessButton#��[ $��17(�$��5,0,5,0q����� *SearchPaymentAdviceCommand+.��Search1   +ShortBody.Resources.UserControls.miniWindow  
������    
HeaderText$ 
Payment Ad��$��1��$��3��   CanClose .  	   Content	 �  �� $
��auto ��� $
��241* �.+��� $ 
Horizontal=�  myDirtyWhite#��[ .+��� -   $��5q�
 � ToolTip$
 Add New Payment Advice��  b_Button#��[ ���� *AddPaCommand+.��Add Payment Advice�� 
�������$��1��$��5,5,5,5q��� $��1,5,5,5q�#��[ $��Delete Payment Advice������ *DeletePaCommand+�� -   $��1,5,5,5q�#��[ $��View Payment Advice������ *ViewPaCommand+&   System.Windows.Controls.DataGrid  -   $��1��   AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ *    CanUserAddRows .    defaultHeaderStyle   ColumnHeaderStyle# [ ���� *PaymentAdvices+   Columns 9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Date+ �� 	Converter -  'ShortBody.ValueConverters.DateFormatter    $ ChequeNumber�� �� *ChequeNumber+  $ CompanyName�� �� *CompanyName+  $ BankName�� �� *
BankName+  $ Vat Rate�� �� *	VatRate+  $ 	Vat Value�� �� *
VatValue+ -   'ShortBody.ValueConverters.DToSConverter    $ TotalAmount�� �� *TotalAmount+     $ IssuedBy�� �� *
IssuedBy+     -     Name$ AddPaymentAdvice��1	   +ShortBody.Resources.UserControls.miniWindow 	  Loaded$ AddPaymentAdvice_Loaded��$��1��$��1��$ Add Payment Advice��$	��600��$	��300��.	 �  �� $
��auto ��� $
��241* ��� $��10 �.+��� $ 
Horizontal=�#��[ .+��� $��10,5,5,5q�#��[ $
 Clear Boxes��$	��CPA������ *
ClearBoxes+.���� $ 
Horizontal=�.+�"
  FontAwesome.WPF.ImageAwesome
   
  Icon$ 
PaintBrush=�$��20���� 
�������$��1��$��5,5,1,5q�� $��1��$��2��#���    � DataContext �� *NewPaymentAdvice+ �� $��8* ��� $	��55* � �� $
��Auto ��� $��* ��� $
��Auto ��� $��* �.+���   tb#��[ $��5q� �� TextAlignment$ Center=����#CA5100$��4������ *Error+$ PropertyChanged=� ��  �� RelativeSource ��  �� AncestorType" >� �� Mode$ FindAncestor=� �� Path$ DataContext��� $��5q�$��1��.+��� #��[ $��Bank :��$ Right=�$��10q�$��Center=��� #��[ $��Cheque Number :��$ Right=�$��10q�$��Center=��� $��1��$��5q�$��1��.+��� $��	5,10,5,10q����� *
BankName+�� $��	5,10,5,10q����� *ChequeNumber+�� $��2��$��5q�$��1��.+��� #��[ $��Client Name :��$ Right=�$��10q�$��Center=��� #��[ $��
Vat_Nhil :��$ Right=�$��10q�$��Center=��� $��3��$��5q�$��1��.+��� $��	5,10,5,10q����� *CompanyName+$ PropertyChanged=�$ TwoWay=��� $��	5,10,5,10q����� *	VatRate+�� $
��Save��$��50�� ��  �� "  $ FindAncestor=�$ DataContext����� *SavePaymentAdviceCommand+