   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ShortBody.ReportsShortBody.Reports  W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=nulleHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.WpfMaterialDesignThemes.Wpf {Sclr-namespace:MaterialDesignThemes.Wpf.Converters;assembly=MaterialDesignThemes.Wpf#MaterialDesignThemes.Wpf.Converters E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  '    !ShortBody.Reports.QuotationReport   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:ShortBody.Reports     XwpfHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.Wpf     j
convertersSclr-namespace:MaterialDesignThemes.Wpf.Converters;assembly=MaterialDesignThemes.Wpf     6cv'clr-namespace:ShortBody.ValueConverters     ?an0clr-namespace:ShortBody.Resources.Helper_Methods     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  :md1http://materialdesigninxaml.net/winfx/xaml/themes  -     � WindowStartupLocation$  CenterScreen=�$	��800��$	��795�� � Icon$4 ./ShortBody;component/Resources/Images/icon.ico�� � Title$ QuotationReport�� � 	Resources *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value �� 
TargetType J� SnapsToDevicePixels	 �� Triggers
 P� Property P� Value   MaterialDesignTextBoxBorder ]� 
Conditions �� Property �� Value  MaterialDesignSelection  MaterialDesignBody  MaterialDesignTextBox �� BasedOn ��Name �� Padding ��Name � UseLayoutRounding(  "MaterialDesignThemes.Wpf.SmartHint  Name   Hint �� Path �� RelativeSource   	HintProxyB  <MaterialDesignThemes.Wpf.Converters.HintProxyFabricConverter   Instance �� 	Converter   HintOpacity   UseFloating   FloatingScale   FloatingOffset(  "MaterialDesignThemes.Wpf.Underline  Name  �� Triggers! �� 
SourceName" �� 
TargetName  PrimaryHueMidBrush)  #MaterialDesignThemes.Wpf.HintAssist  ValidationErrorBrush��%�  '        '�� 5    7  �� "  .���  � ��$ 1q���  � ��
 ���� ��  � ��
 ���� ��  � ��$ 0q���  � �� �� "  .R��� #��z��#��z��#��z�� . ._��� $��
MidTextBox��# z #��z��$��Center=�$��Center=�$��50��	 P� 
 �@J�IsKeyboardFocusWithin . . ���  � ��# �   ]�  ��  �@ 
IsSelected . ��  �@��IsSelectionActive .  ./���  � ��# �  ]�  ��  �@ 
IsSelected . ��  �@��IsSelectionActive . ./���  � ��# �  P� 
 � {� .  . ���  �@J�Opacity$	 .56Q��� " ��8   .���  � ��$ 11(���  � ��$ 0q���  � ��$ Arial)���  � ��$ 0q���  � ��$ 0q���  � �� �� " ��.R�� .+��� $ border��#��z��#��z��#��z�� . $ 0q�._�� #��z��#��z��#��z��.+��� $ PART_ContentHost��|�.  $��Hidden=�$��Hidden=�# z # z   $
 Hint��#��z�� �� $ (wpf:HintAssist.Hint)� �� *TemplatedParent+ ��  �� *TemplatedParent+# Z  �� $" (wpf:HintAssist.HintOpacity)� �� *TemplatedParent+ �� $! (wpf:HintAssist.IsFloating)� �� *TemplatedParent+ �� $$ (wpf:HintAssist.FloatingScale)� �� *TemplatedParent+ �� $% (wpf:HintAssist.FloatingOffset)� �� *TemplatedParent+  $ 	Underline��y��� $0 *(wpf:TextFieldAssist.DecorationVisibility)� �� *TemplatedParent+  ]�  �� $
! Hint�� �@ IsContentNullOrEmpty .  ��  �@J�IsKeyboardFocused . ./��� $
" Hint��# �   � ���� $
" Hint�� �@ HintOpacity$ 1Q�P� 
 �@ 
IsFloating . . ��� $" border�� � ��$ 0 12 0 0q�P� 
 � {� .  . ��� $" border�� �@J�Opacity$
 0.56Q�P� 
 �@J�IsMouseOver . . ��� # �   � ��P� 
 �@J�IsKeyboardFocused . . ��� $" 	Underline�� �@ IsActive . P� 
 �@=�HasError . . ��� # �   � ���� $" 	Underline��# �   � ��.��� -   $��MainGrid��$	��800��# � RowDefinitions# �� $
��Auto ��� $��* �.+��� -   $��TopPanel��$ �� Orientation$$ 
Horizontal=�.+��� -   $��5q�.��"  FontAwesome.WPF.ImageAwesome  %   Icon$% Print=�$��40��$��5q�& � ToolTip$& Print���� -   $��5q�.��  $% search=�$��40��$��5q�$& PrintPreview��,� -   $��Document��$��1��.��/� -   ' �Name$' FD��( /� ColumnWidth$	( 500��.T��� ) �� Margin$) 0,0,0,0q�.r�� # �� $
��Auto ��� $
��auto ��� $
��Auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $$ 
Horizontal=�$��Center=�$��0,0,0,5q�* � DataContext* �� *CurrentCompany+.+��� $	��100��$	��100��$��0,0,20,0q����� *Logo+ 4   .ShortBody.ValueConverters.ByteToImageConverter  �� $��20,0,0,0q�.+��� $��20��$��	ExtraBold"�$��	20,0,20,5q����� *Name+�� $$ 
Horizontal=�.+��� $��5,0,0,0q�.+��� $��	Address :��$��13(�+ �� TextAlignment$+ Right=��� $��Phone :��$��13(�$+ Right=��� $��Email :��$��13(�$+ Right=��� $��5,0,0,0q�$	��200��.+��� $��13(����� *	Address+, �� UpdateSourceTrigger$, PropertyChanged=��� $��13(����� *Phone+$, PropertyChanged=��� $��13(����� *Email+$, PropertyChanged=�� $��1��$��5,1,5,1q�- � ColumnDefinitions- �� $��* ��� $
��Auto ��� $��* �.+��� $��Center=�$��	20,0,20,0q�.+��� $��5��
����  ��� $��2��
����� ��� $��1��$��	QUOTATION��$��Italic$�$��20(�$��Center=�$��	ExtraBold"��� $��2��$��Center=�$��	20,0,20,0q�.+��� $��5��
����  ��� $��2��
����� �� $��2��- �� $
��1.3* ��� $��* �.+��� $��	10,0,10,0q�$��Customer��  NormalGroupBox#��[ * �� *SelectedClient+.���� $$ 
Horizontal=�.+��� $��5,0,0,0q�.+��� $��Name :��$+ Right=��� $��	Address :��$+ Right=��� $��City :��$+ Right=��� $��Requester :��$+ Right=��� $��5,0,0,0q�$	��250��.+��� $
+ Left=����� *Name+$, PropertyChanged=��� $
+ Left=����� *	Address+$, PropertyChanged=��� $
+ Left=����� *City+$, PropertyChanged=��� $
+ Left=�* ��  �� . �� AncestorType". �/ �� Mode$/ FindAncestor=�$ DataContext����� *SelectedQuotation.Requester+$, PropertyChanged=��� $��1��#��[ $�� ��* �� *SelectedQuotation+.���� $$ 
Horizontal=�.+��� $��5,0,0,0q�.+��� $��	Quote # :��$+ Right=��� $��LPO # :��$+ Right=��� $��Date :��$+ Right=��� $��Work Order # :��$+ Right=��� $��5,0,0,0q�$	��120��.+��� ���� *QuoteNumber+�� ���� *LPO+�� ���� *	QuoteDate+$, PropertyChanged=�0 �� Mode$0 TwoWay=� -  'ShortBody.ValueConverters.DateFormatter  �� ���� *WOD+$, PropertyChanged=�$0 TwoWay=�� $��3��- �� $��* ��� $
��auto �.+��� $��Center=�$
��Bold"�$��5q�1 �� TextWrapping$
1 Wrap=�$��15(�* �� *SelectedQuotation+���� *ServiceWanted+$, PropertyChanged=��� -   $��helperPanel��$��1��$$ 
Horizontal=�$��Right=�$��0,0,20,0q�* ��  �� ". �$/ FindAncestor=�$ DataContext�.+��� -	   $��btnFsIncrease��$& Increase Font Size��.��  $% CaretUp=�$��10��$& Bolden���� -
   $��btnFsDecrease��$& Decrease Font Size��.��  $% 	CaretDown=�$��10��$& Bolden���� -   $��btnClearFormatting��$& Clear All Formatting��.��  $% 
PaintBrush=�$��10��$& Bolden���� -   $��	btnBolden��.��  $
% Bold=�$��10��$& Bolden���� -   $��btnUnderline��.��  $% 	Underline=�$��10��$& 	Underline���� -   $��btnItalicize��$& 	Italicize��.��  $% Italic=�$��10���� -   $��btnDeleteItem��$& Delete Selected Item������ *DeleteItemCommand+.��  $% Trash=�$��10���� $��4��* �� *SelectedQuotation+$, PropertyChanged=�$0 TwoWay=�._�� # �� $
��auto ��� $	��560 ��� $
��auto �.+�&	   System.Windows.Controls.DataGrid	  -   $��ItemsDataGrid��$��1��$	��Top=�
���   �$��1q�$��Hidden=�$	��550��$	��550��  QuoteItemsRow2 	  RowStyle#2 [  	 Smoke3 	  AlternatingRowBackground#3 [ 4 �� AlternationCount$4 2��:
   4ShortBody.Resources.Helper_Methods.DataGridExtension5 
  HideAnnotatedColumns5 . 6 	  AutoGenerateColumns6 .  7 	  CanUserReorderColumns7 .  
�������$��10(����� *Items+$, PropertyChanged=�$0 TwoWay=�8 	  Columns8 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn9   Header$	9 QTY��:   Width5  /System.Windows.Controls.DataGridLengthConverter$	: 100 1  +System.Windows.Controls.DataGridBoundColumn;   Binding; �� *QTY+$, PropertyChanged=�$0 TwoWay=�  $9 Description�� 	 elementStyle<   ElementStyle#< [	  
 editingElementStyle=   EditingElementStyle#= [
 $	: 340 ; �� *Description+$, PropertyChanged=�$0 TwoWay=�  $9 UnitCost��$	: 100 ; �� *
UnitCost+$, PropertyChanged=�$0 TwoWay=�  $9 	TotalCost��$	: 100 ; �� *	TotalCost+$, PropertyChanged=�$0 TwoWay=�� $��5��* �� *SelectedQuotation+- �� $��* ��� $
��auto ��� $	��200 �# �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��1��$	��110��$��14(�$��Sub-Total( GHS ) :��$+ Right=��� $��1��$��1��$	��110��$��14(�$��Vat + Nhil % :��$+ Right=��� $��1��$��3��$	��110��$��15(�$
��Bold"�$��Total ( GHS ) :��$+ Right=��� $�� Vat Value : ��$��1��$��2��$��14(�$+ Right=�$��5,0,0,0q��� -   $��tbVatAmount��$��2��$��14(�$��2��$
+ Left=����� *
VatValue+$, PropertyChanged=�$0 TwoWay=� -   'ShortBody.ValueConverters.DToSConverter  �� -   $��
tbSubTotal��$��2��$
+ Left=�$��14(����� *Amount+$, PropertyChanged=�$0 TwoWay=�   �� -   $��tbVat��$��14(�$��2��$��1��$
+ Left=����� *
Vat_Nhil+$, PropertyChanged=�$0 TwoWay=��� -   $��tbTotal��$��2��$��3��$��15(�> �� TextDecorations$> 	Underline{�$
��Bold"����#CA5100$
+ Left=����� *TotalAmount+$, PropertyChanged=�$0 TwoWay=�   �� $��4��$��1��$��2��$+ Center=����� *Others+? �� FallbackValue$'? !Price Excludes VAT + NHIL charges���� $��1,1,1,1q�$
1 Wrap=�$	��250��  NormalTextBox#��[ $��5��$��1��$��2��$��30������ *Miscellenous+�� $��6��$��1��$��Issued By :���� $��5��$��2��$��0,39.97,0,0.98q�$��2������ *
IssuedBy+$, PropertyChanged=�$0 TwoWay=��� $��Bank Acc Details��
���   �$	��350��$��5��$��5q�#��[ * ��  �� ". �$ DataContext�.��� * �� *CompanyAccDetails+$, PropertyChanged=�$0 TwoWay=�- �� $��* ��� $��* ��� $
��Auto �.+��� $��	10,0,10,0q�.+��� $$ 
Horizontal=�$��Right=�.+��� $��Account Name :���� $$ 
Horizontal=�$��Right=�.+��� $��Bank Name :���� $��Account Number :��$��Right=��� $��Bank Branch :��$��Right=��� $��	10,0,10,0q�$��1��$	��100��.+��� ���� *AccountName+$, PropertyChanged=�$0 TwoWay=��� ���� *
BankName+$, PropertyChanged=�$0 TwoWay=��� ���� *AccountNumber+$, PropertyChanged=�$0 TwoWay=��� ���� *
BankBranch+$, PropertyChanged=�$0 TwoWay=��� -   $��SpAccountNavigator��$��2��$��Center=�.+��� -   $��btnUp��  BoderlessButton#��[ .��  $% ArrowUp=�$��7���� -   $��	tbCounter��$��1��@ �� TextAlignment$@ Center=��� -   $��btnDown��#��[ {�.  .��  $% 	ArrowDown=�$��7���� $��Remarks��$��5��$+ Center=�$��Bottom=�$��0,0,0,39.98q�$��3���� 
���   �$��1q�$��7��$��3��$��40��._�(� .���� $+ Center=�$��Center=�$��Center=�$
��bold"�$��monotype corsiva)�$	��400��$��0q����� *Description+�� $��8��$��3��$+ Center=�$��0,0.02,0,15.93q�$��2������ *
QuoteTerms+$, PropertyChanged=�$R? LQUOTE TERMS : This Quote is valid for a period of 30 days from date of issue��.���� $��Center=�$��16��$��9��$��3��$��20,0.07,20,-0.07q�.+��� $��2��
����� ��� $��5��
����  �