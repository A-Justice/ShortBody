   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ShortBody.ReportsShortBody.Reports  W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  %    ShortBody.Reports.PaymentAdvice   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:ShortBody.Reports     ?an0clr-namespace:ShortBody.Resources.Helper_Methods     6cv'clr-namespace:ShortBody.ValueConverters     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  -     � Icon$4  ./ShortBody;component/Resources/Images/icon.ico�� � Title$ PaymentAdvice��$	��800��$	��900�� � 	Resources  �� 
TargetType   MaterialDesignTextBox �� BasedOn �� Property �� Value��%d   '��       7   �� " ��8   .���  � ��$ 14(���  � ��$ Arial)���  � ��$ 0q�.��� $	��900�� � RowDefinitions �� $
��Auto ��� $��* �.+��� -   $��TopPanel�� �� Orientation$ 
Horizontal=�$��5q�.+��� -   .��"  FontAwesome.WPF.ImageAwesome  	   Icon$	 Print=�$��40��$��5q�
 � ToolTip$
 Print��,� -   $��document��$��1��.��/�  /� ColumnWidth$	 500��.T��� .r��  �� $
��auto ��� $��* ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $ 
Horizontal=�$��Center=� � DataContext �� *SelectedCompany+.+��� $	��100��$	��100��$��0,0,20,0q����� *Logo+ �� 	Converter 4   .ShortBody.ValueConverters.ByteToImageConverter  �� $��20,0,0,0q�.+��� $��	ExtraBold"�$��
20,0,20,20q�$��16(����� *Name+�� $ 
Horizontal=�.+��� $��5q�.+��� $��	Address :�� �� TextAlignment$ Right=��� $��Phone :��$ Right=��� $��Email :��$ Right=��� $��5q�$	��200��.+��� $ Center=����� *	Address+ �� UpdateSourceTrigger$ PropertyChanged=��� $ Center=����� *Phone+$ PropertyChanged=��� $ Center=����� *Email+$ PropertyChanged=�� $��1��$��	0,20,0,20q� �� *PaymentAdvice+$ PropertyChanged=� �� Mode$ TwoWay=� � ColumnDefinitions �� $��* ��� $��* �.+��� .+��� $��PAYMENT ADVICE��$��Center=�$��SemiBold"�$��0,0,0,20q��� $ 
Horizontal=�.+��� $��Company Name :��$��Center=��� $��5,0,0,0q�$	��150������ *CompanyName+$ PropertyChanged=�$ TwoWay=��� $��1��$��Right=�.+��� $ 
Horizontal=�.+��� $��Date :��$��80�� �� TextAlignment$ Right=�$��Center=��� $��5,0,0,0q�$	��150������ *Date+$ PropertyChanged=�$ TwoWay=��� $ 
Horizontal=�.+��� $��80��$ Right=�$��	Cheque #:��$��Center=��� $��5,0,0,0q�$	��150������ *ChequeNumber+$ PropertyChanged=�$ TwoWay=��� $ 
Horizontal=�.+��� $��80��$ Right=�$��Bank :��$��Center=��� $��5,0,0,0q�$	��150������ *
BankName+$ PropertyChanged=�$ TwoWay=��� -   $��helperPanel��$��2��$ 
Horizontal=�$��Right=�$��10q� ��  �� RelativeSource ��  �� AncestorType" � �� Mode$ FindAncestor=� �� Path$ DataContext�.+��� -   $��btnDeleteItem��$
 Delete Selected Item������ *DeleteItemCommand+.��  $	 Trash=�$��10��� $��3�� �� *PaymentAdvice+$ PropertyChanged=�$ TwoWay=�.+�&   System.Windows.Controls.DataGrid  -   $��AdvicesDataGrid��
���   � 	 Smoke   AlternatingRowBackground# [  �� AlternationCount$ 2��
�������   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ *    AutoGenerateColumns .  ���� *	Advices+$ PropertyChanged=�$ TwoWay=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ No��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
AdviceId+$ PropertyChanged=�$ TwoWay=�  $
 Date�� �� *
AdviceDate+$ PropertyChanged=�$ TwoWay=�  $ 	Invoice #�� �� *InvoiceNumber+$ PropertyChanged=�$ TwoWay=�  $ Description��  elementStyle   ElementStyle# [   editingElementStyle   EditingElementStyle# [  �� *Description+$ PropertyChanged=�$ TwoWay=�  $ Amount(GHS)�� �� *Amount+$ PropertyChanged=�$ TwoWay=�  $ Remarks�� �� *	Remarks+$ PropertyChanged=�$ TwoWay=��� $��4��$��Right=�$��20q� �� *PaymentAdvice+$ PropertyChanged=�$ TwoWay=�.+��� $ 
Horizontal=�$��2q�.+��� $	��190��$ Right=�$��Vat-rate (%):��$��Center=��� -   $��tbVat��$	��150��$��5,0,0,0q�$
 Left=����� *	VatRate+$ PropertyChanged=�$ TwoWay=��� $ 
Horizontal=�$��2q�.+��� $	��190��$ Right=�$��Vat-value (GHS) :��$��Center=��� -	   $��tbVatAmount��$	��150��$
 Left=�$��5,0,0,0q����� *
VatValue+$ PropertyChanged=�$ TwoWay=��� $ 
Horizontal=�$��2q�.+��� $	��190��$ Right=�$��Sub-Total (GHS) :��$��Center=��� -
   $��
tbSubTotal��$	��150��$
 Left=�$��5,0,0,0q����� *Amount+$ PropertyChanged=�$ TwoWay=��� $ 
Horizontal=�$��2q�.+��� $	��190��$
��Bold"�$ Right=�$��Total Amount (GHS) :��$��Center=��� -   $��tbTotal��$	��150��$
 Left=�$��5,0,0,0q�  �� TextDecorations$  	Underline{����#CA5100���� *TotalAmount+$ PropertyChanged=�$ TwoWay=��� $ 
Horizontal=�$��2q�.+��� $��Issued By :��$	��190��$ Right=�$��Center=��� $	��150��$
 Left=�$��5,0,0,0q����� *
IssuedBy+$ PropertyChanged=�$ TwoWay=�